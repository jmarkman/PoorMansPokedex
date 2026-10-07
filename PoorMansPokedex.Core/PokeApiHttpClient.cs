using System.Collections.Concurrent;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace PoorMansPokedex.Core;

public class PokeApiHttpClient : IPokeApiHttpClient
{
    private readonly HttpClient httpClient;
    private readonly ConcurrentDictionary<string, CachedResponse> responseCache = new(StringComparer.Ordinal);

    public PokeApiHttpClient(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<HttpResponseMessage> GetAsync(string requestUri, bool bypassCache = false)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(requestUri);

        var uri = this.ResolveRequestUri(requestUri);
        var cacheKey = uri.AbsoluteUri;

        if (!bypassCache && this.responseCache.TryGetValue(cacheKey, out var cachedResponse))
        {
            return cachedResponse.CreateResponse();
        }

        if (bypassCache)
        {
            this.responseCache.TryRemove(cacheKey, out _);
        }

        using var response = await this.httpClient.GetAsync(uri);
        response.EnsureSuccessStatusCode();

        var newCachedResponse = await CachedResponse.CreateAsync(response);
        this.responseCache[cacheKey] = newCachedResponse;
        return newCachedResponse.CreateResponse();
    }

    private Uri ResolveRequestUri(string requestUri)
    {
        if (Uri.TryCreate(requestUri, UriKind.Absolute, out var absoluteUri))
        {
            return absoluteUri;
        }

        if (this.httpClient.BaseAddress is null)
        {
            throw new InvalidOperationException("The HttpClient must have a BaseAddress to resolve relative request URIs.");
        }

        return new Uri(this.httpClient.BaseAddress, requestUri);
    }

    private sealed record CachedResponse(
        HttpStatusCode StatusCode,
        string? ReasonPhrase,
        Version Version,
        byte[] Content,
        HeaderValue[] Headers,
        HeaderValue[] ContentHeaders)
    {
        public static async Task<CachedResponse> CreateAsync(HttpResponseMessage response)
        {
            var content = await response.Content.ReadAsByteArrayAsync();
            return new CachedResponse(
                response.StatusCode,
                response.ReasonPhrase,
                response.Version,
                content,
                SnapshotHeaders(response.Headers),
                SnapshotHeaders(response.Content.Headers));
        }

        public HttpResponseMessage CreateResponse()
        {
            var content = new ByteArrayContent(this.Content);
            foreach (var header in this.ContentHeaders)
            {
                content.Headers.TryAddWithoutValidation(header.Name, header.Values);
            }

            var response = new HttpResponseMessage(this.StatusCode)
            {
                Content = content,
                ReasonPhrase = this.ReasonPhrase,
                Version = this.Version
            };

            foreach (var header in this.Headers)
            {
                response.Headers.TryAddWithoutValidation(header.Name, header.Values);
            }

            return response;
        }

        private static HeaderValue[] SnapshotHeaders(HttpHeaders headers)
        {
            var snapshot = new List<HeaderValue>();
            foreach (KeyValuePair<string, IEnumerable<string>> header in headers)
            {
                snapshot.Add(new HeaderValue(header.Key, header.Value.ToArray()));
            }

            return snapshot.ToArray();
        }
    }

    private sealed record HeaderValue(string Name, string[] Values);
}
