using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class SpritesVersions
{
    [JsonPropertyName("generation-i")]
    public Generation1? Generation1 { get; set; }

    [JsonPropertyName("generation-ii")]
    public Generation2? Generation2 { get; set; }

    [JsonPropertyName("generation-iii")]
    public Generation3? Generation3 { get; set; }

    [JsonPropertyName("generation-iv")]
    public Generation4? Generation4 { get; set; }

    [JsonPropertyName("generation-v")]
    public Generation5? Generation5 { get; set; }

    [JsonPropertyName("generation-vi")]
    public Generation6? Generation6 { get; set; }

    [JsonPropertyName("generation-vii")]
    public Generation7? Generation7 { get; set; }

    [JsonPropertyName("generation-viii")]
    public Generation8? Generation8 { get; set; }

    [JsonPropertyName("generation-ix")]
    public Generation9? Generation9 { get; set; }
}
