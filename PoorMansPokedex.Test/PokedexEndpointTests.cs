using System.Text.Json;
using Moq;
using PoorMansPokedex.Core;
using PoorMansPokedex.Core.Endpoints;
using PoorMansPokedex.Test.MockingTools;
using Shouldly;

namespace PoorMansPokedex.Test;

public class PokedexEndpointTests
{
    [Test]
    public async Task GetEntryAsync_WhenResponseIsMostlyPopulated_ReturnsDeserializedEntry()
    {
        var expectedEntry = PokedexEntryBuilder.CreateFullyPopulated();
        var responseBody = JsonSerializer.Serialize(expectedEntry);
        var cachingHttpClientMock = new Mock<ICachingHttpClient>();
        cachingHttpClientMock
            .Setup(client => client.GetAsync(It.IsAny<string>(), It.IsAny<bool>()))
            .ReturnsAsync(responseBody);
        var endpoint = new PokedexEndpoint(cachingHttpClientMock.Object);

        var actualEntry = await endpoint.GetEntryAsync(expectedEntry.Name);

        actualEntry.Id.ShouldBe(expectedEntry.Id);
        actualEntry.Name.ShouldBe(expectedEntry.Name);
        actualEntry.BaseExperience.ShouldBe(expectedEntry.BaseExperience);
        actualEntry.Abilities[0].Ability?.Name.ShouldBe("overgrow");
        actualEntry.Species.Name.ShouldBe(expectedEntry.Species.Name);
        actualEntry.Sprites.FrontDefault.ShouldBe(expectedEntry.Sprites.FrontDefault);
        actualEntry.Types[0].Type.Name.ShouldBe("grass");
    }
}
