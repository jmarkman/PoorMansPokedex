using PoorMansPokedex.Core.Endpoints;

namespace PoorMansPokedex.Core;

public interface IPokeApiService
{
    IPokedexEndpoint PokedexEndpoint { get; }
}
