using System.Net;
using System.Text.Json;
using Moq;
using PoorMansPokedex.Core;
using PoorMansPokedex.Core.Endpoints;
using PoorMansPokedex.Core.Models;
using PoorMansPokedex.Test.MockingTools;
using Shouldly;

namespace PoorMansPokedex.Test;

public class PokedexEndpointTests
{
    [Test]
    public async Task GetEntryAsyncByNameDeserializesEntryAndRequestsNamePath()
    {
        var expectedEntry = PokedexEntryBuilder.CreateFullyPopulated();
        var httpClient = CreateHttpClientMock(JsonSerializer.Serialize(expectedEntry));
        var endpoint = new PokedexEndpoint(httpClient.Object);

        var actualEntry = await endpoint.GetEntryAsync("pikachu");

        actualEntry.Name.ShouldBe(expectedEntry.Name);
        actualEntry.Id.ShouldBe(expectedEntry.Id);
        actualEntry.Abilities.ShouldHaveSingleItem().Ability!.Name.ShouldBe("static");
        actualEntry.Moves.ShouldHaveSingleItem().Move.Name.ShouldBe("thunder-shock");
        actualEntry.Stats.ShouldHaveSingleItem().BaseStat.ShouldBe(35);
        actualEntry.Types.ShouldHaveSingleItem().Type.Name.ShouldBe("electric");
        httpClient.Verify(client => client.GetAsync("pokemon/pikachu", false), Times.Once);
    }

    [Test]
    public async Task GetEntryAsyncByIdDeserializesEntryAndRequestsIdPath()
    {
        var expectedEntry = PokedexEntryBuilder.CreateFullyPopulated();
        var httpClient = CreateHttpClientMock(JsonSerializer.Serialize(expectedEntry));
        var endpoint = new PokedexEndpoint(httpClient.Object);

        var actualEntry = await endpoint.GetEntryAsync(25);

        actualEntry.Id.ShouldBe(expectedEntry.Id);
        actualEntry.Name.ShouldBe(expectedEntry.Name);
        actualEntry.Species.Name.ShouldBe("pikachu");
        actualEntry.Cries.Latest.ShouldBe("pikachu.ogg");
        httpClient.Verify(client => client.GetAsync("pokemon/25", false), Times.Once);
    }

    [Test]
    public async Task GetEntryAsyncPropagatesHttpWrapperExceptions()
    {
        var expectedException = new HttpRequestException("API unavailable");
        var httpClient = new Mock<IPokeApiHttpClient>(MockBehavior.Strict);
        httpClient
            .Setup(client => client.GetAsync("pokemon/pikachu", false))
            .ThrowsAsync(expectedException);
        var endpoint = new PokedexEndpoint(httpClient.Object);

        var actualException = await Should.ThrowAsync<HttpRequestException>(
            () => endpoint.GetEntryAsync("pikachu"));

        actualException.ShouldBeSameAs(expectedException);
        httpClient.Verify(client => client.GetAsync("pokemon/pikachu", false), Times.Once);
    }

    [Test]
    public async Task GetEntryAsyncEscapesNamePathSegment()
    {
        var httpClient = CreateHttpClientMock("{\"name\":\"mr-mime\"}");
        var endpoint = new PokedexEndpoint(httpClient.Object);

        await endpoint.GetEntryAsync("mr mime");

        httpClient.Verify(client => client.GetAsync("pokemon/mr%20mime", false), Times.Once);
    }

    private static Mock<IPokeApiHttpClient> CreateHttpClientMock(string jsonBody)
    {
        var httpClient = new Mock<IPokeApiHttpClient>(MockBehavior.Strict);
        httpClient
            .Setup(client => client.GetAsync(It.IsAny<string>(), It.IsAny<bool>()))
            .ReturnsAsync(() => new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(jsonBody)
            });
        return httpClient;
    }
}
