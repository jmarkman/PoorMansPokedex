using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class OfficialArtworkVersion
{
    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; set; }
}
