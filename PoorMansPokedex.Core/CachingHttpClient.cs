using System.Collections.Concurrent;

namespace PoorMansPokedex.Core;

public class CachingHttpClient : ICachingHttpClient
{
    private readonly HttpClient httpClient;
    private readonly ConcurrentDictionary<string, string> responseCache = new(StringComparer.Ordinal);

    public CachingHttpClient(HttpClient httpClient)
    {
        ArgumentNullException.ThrowIfNull(httpClient);
        this.httpClient = httpClient;
    }

    public async Task<string> GetAsync(string requestPath, bool bypassCache = false)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(requestPath);

        var requestUri = this.ResolveRequestUri(requestPath);
        var cacheKey = requestUri.AbsoluteUri;

        if (!bypassCache && this.responseCache.TryGetValue(cacheKey, out var cachedResponse))
        {
            return cachedResponse;
        }

        using var response = await this.httpClient.GetAsync(requestUri);
        if (!response.IsSuccessStatusCode)
        {
            throw new HttpRequestException(
                $"GET request to '{requestUri}' failed with status code {(int)response.StatusCode} ({response.StatusCode}).",
                null,
                response.StatusCode);
        }

        var responseBody = await response.Content.ReadAsStringAsync();
        this.responseCache[cacheKey] = responseBody;

        return responseBody;
    }

    private Uri ResolveRequestUri(string requestPath)
    {
        if (!Uri.TryCreate(requestPath, UriKind.Relative, out var relativeUri))
        {
            throw new ArgumentException("The request path must be relative.", nameof(requestPath));
        }

        var baseAddress = this.httpClient.BaseAddress
            ?? throw new InvalidOperationException("HttpClient.BaseAddress must be set before making a request.");

        return new Uri(baseAddress, relativeUri);
    }
}
