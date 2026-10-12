using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class Generation3
{
    [JsonPropertyName("icons")]
    public SpriteIconsFrontDefault? Icons { get; set; }

    [JsonPropertyName("emerald")]
    public SpriteVariantGeneration3Emerald? Emerald { get; set; }

    [JsonPropertyName("ruby-sapphire")]
    public SpriteVariantGeneration3? RubySapphire { get; set; }

    [JsonPropertyName("firered-leafgreen")]
    public SpriteVariantGeneration3? FireRedLeafGreen { get; set; }
}
