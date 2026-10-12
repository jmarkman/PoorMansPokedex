using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class OfficialArtwork
{
    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; set; }

    [JsonPropertyName("front_shiny")]
    public string? FrontShiny { get; set; }

    [JsonPropertyName("versions")]
    public OfficialArtworkVersions? Versions { get; set; }
}
