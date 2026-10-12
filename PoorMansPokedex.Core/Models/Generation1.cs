using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class Generation1
{
    [JsonPropertyName("yellow")]
    public SpriteVariantGeneration1Yellow? Yellow { get; set; }

    [JsonPropertyName("red-blue")]
    public SpriteVariantGeneration1RedBlue? RedBlue { get; set; }

    [JsonPropertyName("red-green-japan")]
    public SpriteVariantGeneration1RedGreenJapan? RedGreenJapan { get; set; }
}
