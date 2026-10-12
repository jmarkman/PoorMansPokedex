using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class Sprites
{
    [JsonPropertyName("back_default")]
    public string? BackDefault { get; set; }

    [JsonPropertyName("back_female")]
    public string? BackFemale { get; set; }

    [JsonPropertyName("back_shiny")]
    public string? BackShiny { get; set; }

    [JsonPropertyName("back_shiny_female")]
    public string? BackShinyFemale { get; set; }

    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; set; }

    [JsonPropertyName("front_female")]
    public string? FrontFemale { get; set; }

    [JsonPropertyName("front_shiny")]
    public string? FrontShiny { get; set; }

    [JsonPropertyName("front_shiny_female")]
    public string? FrontShinyFemale { get; set; }

    [JsonPropertyName("other")]
    public OtherSprites Other { get; set; } = new();

    [JsonPropertyName("versions")]
    public SpritesVersions? Versions { get; set; }
}
