using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class OfficialArtworkGeneration2
{
    [JsonPropertyName("gold-and-silver")]
    public OfficialArtworkVersion? GoldAndSilver { get; set; }
}
