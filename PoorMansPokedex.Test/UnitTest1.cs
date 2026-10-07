using System.Net;
using System.Net.Http;
using Moq;
using Moq.Protected;
using PoorMansPokedex.Core;
using PoorMansPokedex.Test.MockingTools;
using Shouldly;

namespace PoorMansPokedex.Test;

public class PokeApiHttpClientTests
{
    [Test]
    public async Task GetAsync_ThrowsForNotFoundResponse()
    {
        using var mockedClient = MockedHttpClient.Create(HttpStatusCode.NotFound, "{\"detail\":\"missing\"}");
        var client = new PokeApiHttpClient(mockedClient.Client);

        var exception = await Should.ThrowAsync<HttpRequestException>(
            () => client.GetAsync("pokemon/missing"));

        exception.StatusCode.ShouldBe(HttpStatusCode.NotFound);
        exception.Message.ShouldContain("404");
    }

    [Test]
    public async Task GetAsync_ThrowsForInternalServerError()
    {
        using var mockedClient = MockedHttpClient.Create(HttpStatusCode.InternalServerError, "{\"error\":\"server issue\"}");
        var client = new PokeApiHttpClient(mockedClient.Client);

        var exception = await Should.ThrowAsync<HttpRequestException>(
            () => client.GetAsync("pokemon/pikachu"));

        exception.StatusCode.ShouldBe(HttpStatusCode.InternalServerError);
        exception.Message.ShouldContain("500");
    }

    [Test]
    public async Task GetAsync_ReturnsCachedResponseForRepeatRequest()
    {
        using var mockedClient = MockedHttpClient.Create(HttpStatusCode.OK, "{\"name\":\"pikachu\"}");
        var client = new PokeApiHttpClient(mockedClient.Client);

        using var firstResponse = await client.GetAsync("pokemon/pikachu");
        using var secondResponse = await client.GetAsync("pokemon/pikachu");

        (await firstResponse.Content.ReadAsStringAsync()).ShouldBe("{\"name\":\"pikachu\"}");
        (await secondResponse.Content.ReadAsStringAsync()).ShouldBe("{\"name\":\"pikachu\"}");

        mockedClient.HandlerMock.Protected().Verify(
            "SendAsync",
            Times.Once(),
            ItExpr.Is<HttpRequestMessage>(request =>
                request.Method == HttpMethod.Get &&
                request.RequestUri != null &&
                request.RequestUri.ToString() == "https://pokeapi.co/api/v2/pokemon/pikachu"),
            ItExpr.IsAny<CancellationToken>());
    }

    [Test]
    public async Task GetAsync_BypassCacheInvokesHandlerAgain()
    {
        using var mockedClient = MockedHttpClient.Create(HttpStatusCode.OK, "{\"name\":\"pikachu\"}");
        var client = new PokeApiHttpClient(mockedClient.Client);

        using var firstResponse = await client.GetAsync("pokemon/pikachu");
        using var bypassedResponse = await client.GetAsync("pokemon/pikachu", bypassCache: true);

        (await firstResponse.Content.ReadAsStringAsync()).ShouldBe("{\"name\":\"pikachu\"}");
        (await bypassedResponse.Content.ReadAsStringAsync()).ShouldBe("{\"name\":\"pikachu\"}");

        mockedClient.HandlerMock.Protected().Verify(
            "SendAsync",
            Times.Exactly(2),
            ItExpr.Is<HttpRequestMessage>(request =>
                request.Method == HttpMethod.Get &&
                request.RequestUri != null &&
                request.RequestUri.ToString() == "https://pokeapi.co/api/v2/pokemon/pikachu"),
            ItExpr.IsAny<CancellationToken>());
    }
}
