namespace PoorMansPokedex.Core;

public interface ICachingHttpClient
{
    Task<string> GetAsync(string requestPath, bool bypassCache = false);
}
