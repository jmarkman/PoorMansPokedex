using System.Text.Json;
using PoorMansPokedex.Core.Models;

namespace PoorMansPokedex.Core.Endpoints;

public class PokedexEndpoint : IPokedexEndpoint
{
    private readonly IPokeApiHttpClient httpClient;

    public PokedexEndpoint(IPokeApiHttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<PokedexEntry> GetEntryAsync(string name)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);

        return await this.GetEntryFromPathAsync($"pokemon/{Uri.EscapeDataString(name)}");
    }

    public async Task<PokedexEntry> GetEntryAsync(int id)
    {
        return await this.GetEntryFromPathAsync($"pokemon/{id}");
    }

    private async Task<PokedexEntry> GetEntryFromPathAsync(string path)
    {
        using var response = await this.httpClient.GetAsync(path);
        await using var contentStream = await response.Content.ReadAsStreamAsync();
        return await JsonSerializer.DeserializeAsync<PokedexEntry>(contentStream)
            ?? throw new JsonException("The Pokemon response did not contain a Pokedex entry.");
    }
}
