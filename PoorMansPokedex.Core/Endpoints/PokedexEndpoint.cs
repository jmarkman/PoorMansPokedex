using System.Text.Json;
using PoorMansPokedex.Core.Models;

namespace PoorMansPokedex.Core.Endpoints;

public class PokedexEndpoint : IPokedexEndpoint
{
    private readonly ICachingHttpClient cachingHttpClient;

    public PokedexEndpoint(ICachingHttpClient cachingHttpClient)
    {
        ArgumentNullException.ThrowIfNull(cachingHttpClient);
        this.cachingHttpClient = cachingHttpClient;
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

    private async Task<PokedexEntry> GetEntryFromPathAsync(string requestPath)
    {
        var responseBody = await this.cachingHttpClient.GetAsync(requestPath);
        return JsonSerializer.Deserialize<PokedexEntry>(responseBody)
            ?? throw new JsonException($"The response for '{requestPath}' did not contain a PokedexEntry.");
    }
}
