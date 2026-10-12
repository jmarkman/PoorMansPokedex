using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class SpriteVariantGeneration3Emerald
{
    [JsonPropertyName("back_shiny")]
    public string? BackShiny { get; set; }

    [JsonPropertyName("front_shiny")]
    public string? FrontShiny { get; set; }

    [JsonPropertyName("back_default")]
    public string? BackDefault { get; set; }

    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; set; }

    [JsonPropertyName("animated")]
    public AnimatedSpritesBackShinyFrontShinyBackDefaultFrontDefault? Animated { get; set; }
}
