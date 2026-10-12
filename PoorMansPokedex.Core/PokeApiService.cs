using PoorMansPokedex.Core.Endpoints;

namespace PoorMansPokedex.Core;

public class PokeApiService : IPokeApiService
{
    private readonly HttpClient httpClient;

    public PokeApiService(HttpClient httpClient)
    {
        ArgumentNullException.ThrowIfNull(httpClient);

        this.httpClient = httpClient;
        this.httpClient.BaseAddress ??= new Uri("https://pokeapi.co/api/v2/");
        this.PokedexEndpoint = new PokedexEndpoint(new CachingHttpClient(this.httpClient));
    }

    public IPokedexEndpoint PokedexEndpoint { get; }
}
