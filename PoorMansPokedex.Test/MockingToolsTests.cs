using System.Net;
using PoorMansPokedex.Test.MockingTools;

namespace PoorMansPokedex.Test;

public class MockingToolsTests
{
    [Test]
    public void PokedexEntryBuilderCreatesPopulatedEmptyAndNullableVariations()
    {
        var populatedEntry = PokedexEntryBuilder.CreateFullyPopulated();
        var emptyEntry = PokedexEntryBuilder.CreateWithEmptyCollections();
        var nullableEntry = PokedexEntryBuilder.CreateWithNullableNestedData();
        var minimalEntry = PokedexEntryBuilder.CreateMinimal();

        Assert.That(populatedEntry.Abilities, Is.Not.Empty);
        Assert.That(populatedEntry.Moves, Is.Not.Empty);
        Assert.That(populatedEntry.PastStats, Is.Not.Empty);
        Assert.That(populatedEntry.Types, Is.Not.Empty);
        Assert.That(emptyEntry.Abilities, Is.Empty);
        Assert.That(emptyEntry.Moves, Is.Empty);
        Assert.That(emptyEntry.Stats, Is.Empty);
        Assert.That(nullableEntry.Abilities[0].Ability, Is.Null);
        Assert.That(nullableEntry.Cries.Latest, Is.Null);
        Assert.That(nullableEntry.Sprites.FrontDefault, Is.Null);
        Assert.That(minimalEntry.Name, Is.EqualTo("bulbasaur"));
    }

    [TestCase(HttpStatusCode.OK, "{\"name\":\"bulbasaur\"}")]
    [TestCase(HttpStatusCode.NotFound, "{\"error\":\"missing\"}")]
    public async Task MockedHttpClientReturnsConfiguredStatusAndBody(
        HttpStatusCode statusCode,
        string jsonBody)
    {
        using var mockedHttp = MockedHttpClient.Create(
            statusCode,
            jsonBody,
            request => request.Method == HttpMethod.Get
                && request.RequestUri?.AbsolutePath == "/api/v2/pokemon/bulbasaur");

        using var response = await mockedHttp.Client.GetAsync("pokemon/bulbasaur");
        var actualBody = await response.Content.ReadAsStringAsync();

        Assert.That(response.StatusCode, Is.EqualTo(statusCode));
        Assert.That(actualBody, Is.EqualTo(jsonBody));
    }
}
