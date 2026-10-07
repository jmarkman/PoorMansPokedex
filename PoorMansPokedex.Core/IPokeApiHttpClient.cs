using System.Net.Http;

namespace PoorMansPokedex.Core;

public interface IPokeApiHttpClient
{
    Task<HttpResponseMessage> GetAsync(string requestUri, bool bypassCache = false);
}
