using System.Net;
using Moq;
using Moq.Protected;
using PoorMansPokedex.Core.Models;
using Shouldly;

namespace PoorMansPokedex.Test.MockingTools;

public class MockingToolsTests
{
    [Test]
    public void CreateFullyPopulated_ReturnsEntryWithPopulatedCollections()
    {
        var entry = PokedexEntryBuilder.CreateFullyPopulated();

        entry.Abilities.ShouldNotBeEmpty();
        entry.PastAbilities.ShouldNotBeEmpty();
        entry.Forms.ShouldNotBeEmpty();
        entry.GameIndices.ShouldNotBeEmpty();
        entry.HeldItems.ShouldNotBeEmpty();
        entry.Moves.ShouldNotBeEmpty();
        entry.Stats.ShouldNotBeEmpty();
        entry.PastStats.ShouldNotBeEmpty();
        entry.Types.ShouldNotBeEmpty();
        entry.PastTypes.ShouldNotBeEmpty();
        entry.Sprites.FrontDefault.ShouldNotBeNullOrEmpty();
    }

    [Test]
    public void CreateMinimal_ReturnsEntryWithDefaultValuesAndEmptyCollections()
    {
        var entry = PokedexEntryBuilder.CreateMinimal();

        entry.Name.ShouldBeEmpty();
        entry.Abilities.ShouldBeEmpty();
        entry.PastAbilities.ShouldBeEmpty();
        entry.Forms.ShouldBeEmpty();
        entry.GameIndices.ShouldBeEmpty();
        entry.HeldItems.ShouldBeEmpty();
        entry.Moves.ShouldBeEmpty();
        entry.Stats.ShouldBeEmpty();
        entry.PastStats.ShouldBeEmpty();
        entry.Types.ShouldBeEmpty();
        entry.PastTypes.ShouldBeEmpty();
        entry.Sprites.FrontDefault.ShouldBeNull();
    }

    [Test]
    public async Task CreateHttpClient_ReturnsConfiguredResponsesInOrder()
    {
        using var firstResponse = new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent("first")
        };
        using var secondResponse = new HttpResponseMessage(HttpStatusCode.NotFound)
        {
            Content = new StringContent("second")
        };
        using var client = HttpClientMockFactory.CreateHttpClient(
            out var handlerMock,
            firstResponse,
            secondResponse);

        using var firstResult = await client.GetAsync("https://example.test/first");
        using var secondResult = await client.GetAsync("https://example.test/second");

        firstResult.StatusCode.ShouldBe(HttpStatusCode.OK);
        (await firstResult.Content.ReadAsStringAsync()).ShouldBe("first");
        secondResult.StatusCode.ShouldBe(HttpStatusCode.NotFound);
        (await secondResult.Content.ReadAsStringAsync()).ShouldBe("second");
        handlerMock.Protected().Verify(
            "SendAsync",
            Times.Exactly(2),
            ItExpr.IsAny<HttpRequestMessage>(),
            ItExpr.IsAny<CancellationToken>());
    }
}
