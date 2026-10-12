using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class AnimatedSpritesFrontShinyFrontDefault
{
    [JsonPropertyName("front_shiny")]
    public string? FrontShiny { get; set; }

    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; set; }
}
