using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class Generation5
{
    [JsonPropertyName("icons")]
    public SpriteIconsWithAnimatedFrontDefault? Icons { get; set; }

    [JsonPropertyName("black-white")]
    public SpriteVariantGeneration5? BlackWhite { get; set; }
}
