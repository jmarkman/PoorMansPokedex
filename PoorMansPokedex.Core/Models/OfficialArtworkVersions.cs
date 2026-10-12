using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class OfficialArtworkVersions
{
    [JsonPropertyName("generation-i")]
    public OfficialArtworkGeneration1? Generation1 { get; set; }

    [JsonPropertyName("generation-ii")]
    public OfficialArtworkGeneration2? Generation2 { get; set; }
}
