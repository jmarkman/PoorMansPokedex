using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class SpriteIconsWithAnimatedFrontDefault
{
    [JsonPropertyName("animated")]
    public AnimatedSpritesFrontDefault? Animated { get; set; }

    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; set; }
}
