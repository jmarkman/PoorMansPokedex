using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class SpriteVariantGeneration1Yellow
{
    [JsonPropertyName("back_gbc")]
    public string? BackGbc { get; set; }

    [JsonPropertyName("back_gray")]
    public string? BackGray { get; set; }

    [JsonPropertyName("front_gbc")]
    public string? FrontGbc { get; set; }

    [JsonPropertyName("front_gray")]
    public string? FrontGray { get; set; }

    [JsonPropertyName("back_default")]
    public string? BackDefault { get; set; }

    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; set; }

    [JsonPropertyName("back_transparent")]
    public string? BackTransparent { get; set; }

    [JsonPropertyName("front_transparent")]
    public string? FrontTransparent { get; set; }

    [JsonPropertyName("back_transparent_gray")]
    public string? BackTransparentGray { get; set; }

    [JsonPropertyName("front_transparent_gray")]
    public string? FrontTransparentGray { get; set; }
}
