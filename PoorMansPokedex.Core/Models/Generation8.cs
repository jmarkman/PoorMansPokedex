using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class Generation8
{
    [JsonPropertyName("icons")]
    public SpriteIconsFrontFemaleFrontDefault? Icons { get; set; }

    [JsonPropertyName("sword-shield")]
    public SpriteVariantStandardWithIconsFrontFemaleFrontDefault? SwordShield { get; set; }

    [JsonPropertyName("legends-arceus")]
    public SpriteVariantStandardWithIconsFull? LegendsArceus { get; set; }

    [JsonPropertyName("brilliant-diamond-shining-pearl")]
    public SpriteVariantStandardWithIconsFrontDefault? BrilliantDiamondShiningPearl { get; set; }
}
