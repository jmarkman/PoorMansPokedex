using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class Generation6
{
    [JsonPropertyName("x-y")]
    public SpriteVariantStandard? XY { get; set; }

    [JsonPropertyName("icons")]
    public SpriteIconsFrontFemaleFrontDefault? Icons { get; set; }

    [JsonPropertyName("omega-ruby-alpha-sapphire")]
    public SpriteVariantStandard? OmegaRubyAlphaSapphire { get; set; }
}
