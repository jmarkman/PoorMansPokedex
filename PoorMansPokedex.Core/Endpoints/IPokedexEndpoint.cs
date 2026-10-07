using PoorMansPokedex.Core.Models;

namespace PoorMansPokedex.Core.Endpoints;

public interface IPokedexEndpoint
{
    Task<PokedexEntry> GetEntryAsync(string name);

    Task<PokedexEntry> GetEntryAsync(int id);
}
