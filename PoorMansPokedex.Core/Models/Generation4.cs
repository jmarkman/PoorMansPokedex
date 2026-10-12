using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class Generation4
{
    [JsonPropertyName("icons")]
    public SpriteIconsFrontDefault? Icons { get; set; }

    [JsonPropertyName("platinum")]
    public SpriteVariantGeneration4? Platinum { get; set; }

    [JsonPropertyName("diamond-pearl")]
    public SpriteVariantGeneration4? DiamondPearl { get; set; }

    [JsonPropertyName("heartgold-soulsilver")]
    public SpriteVariantGeneration4? HeartGoldSoulSilver { get; set; }
}
