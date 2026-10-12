using System.Net;
using Moq;
using Moq.Protected;
using PoorMansPokedex.Core;
using PoorMansPokedex.Test.MockingTools;
using Shouldly;

namespace PoorMansPokedex.Test;

public class CachingHttpClientTests
{
    private static readonly Uri BaseAddress = new("https://example.test/api/v2/");

    [TestCase(HttpStatusCode.NotFound)]
    [TestCase(HttpStatusCode.InternalServerError)]
    public async Task GetAsync_WhenResponseIsUnsuccessful_ThrowsHttpRequestExceptionWithStatusAndRequestDetails(
        HttpStatusCode statusCode)
    {
        using var response = CreateResponse(statusCode, "failure");
        using var httpClient = HttpClientMockFactory.CreateHttpClient(out _, response);
        httpClient.BaseAddress = BaseAddress;
        var cachingHttpClient = new CachingHttpClient(httpClient);

        var exception = await Should.ThrowAsync<HttpRequestException>(
            () => cachingHttpClient.GetAsync("pokemon/1"));

        exception.StatusCode.ShouldBe(statusCode);
        exception.Message.ShouldContain(
            $"GET request to '{new Uri(BaseAddress, "pokemon/1")}' failed with status code {(int)statusCode} ({statusCode}).");
    }

    [Test]
    public async Task GetAsync_WhenPathWasRequestedAlready_ReturnsCachedBodyWithoutAnotherRequest()
    {
        using var response = CreateResponse(HttpStatusCode.OK, "cached body");
        using var httpClient = HttpClientMockFactory.CreateHttpClient(out var handlerMock, response);
        httpClient.BaseAddress = BaseAddress;
        var cachingHttpClient = new CachingHttpClient(httpClient);

        var firstBody = await cachingHttpClient.GetAsync("pokemon/1");
        var secondBody = await cachingHttpClient.GetAsync("pokemon/1");

        firstBody.ShouldBe("cached body");
        secondBody.ShouldBe(firstBody);
        handlerMock.Protected().Verify(
            "SendAsync",
            Times.Once(),
            ItExpr.IsAny<HttpRequestMessage>(),
            ItExpr.IsAny<CancellationToken>());
    }

    [Test]
    public async Task GetAsync_WhenBypassingCache_FetchesAndCachesFreshBody()
    {
        using var initialResponse = CreateResponse(HttpStatusCode.OK, "initial body");
        using var refreshedResponse = CreateResponse(HttpStatusCode.OK, "refreshed body");
        using var httpClient = HttpClientMockFactory.CreateHttpClient(
            out var handlerMock,
            initialResponse,
            refreshedResponse);
        httpClient.BaseAddress = BaseAddress;
        var cachingHttpClient = new CachingHttpClient(httpClient);

        var initialBody = await cachingHttpClient.GetAsync("pokemon/1");
        var refreshedBody = await cachingHttpClient.GetAsync("pokemon/1", bypassCache: true);
        var cachedBody = await cachingHttpClient.GetAsync("pokemon/1");

        initialBody.ShouldBe("initial body");
        refreshedBody.ShouldBe("refreshed body");
        cachedBody.ShouldBe(refreshedBody);
        handlerMock.Protected().Verify(
            "SendAsync",
            Times.Exactly(2),
            ItExpr.IsAny<HttpRequestMessage>(),
            ItExpr.IsAny<CancellationToken>());
    }

    private static HttpResponseMessage CreateResponse(HttpStatusCode statusCode, string body)
    {
        return new HttpResponseMessage(statusCode)
        {
            Content = new StringContent(body)
        };
    }
}
