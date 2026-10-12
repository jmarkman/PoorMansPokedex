using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class SpriteVariantGeneration1RedGreenJapan
{
    [JsonPropertyName("back_gray")]
    public string? BackGray { get; set; }

    [JsonPropertyName("front_gray")]
    public string? FrontGray { get; set; }

    [JsonPropertyName("back_default")]
    public string? BackDefault { get; set; }

    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; set; }
}
