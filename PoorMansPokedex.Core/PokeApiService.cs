using System.Net.Http;
using PoorMansPokedex.Core.Endpoints;

namespace PoorMansPokedex.Core;

public class PokeApiService : IPokeApiService
{
    private readonly HttpClient httpClient;

    public IPokedexEndpoint PokedexEndpoint { get; }

    public PokeApiService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        this.PokedexEndpoint = new PokedexEndpoint(new PokeApiHttpClient(this.httpClient));
    }
}
