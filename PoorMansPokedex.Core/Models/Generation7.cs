using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class Generation7
{
    [JsonPropertyName("icons")]
    public SpriteIconsFrontFemaleFrontDefault? Icons { get; set; }

    [JsonPropertyName("ultra-sun-ultra-moon")]
    public SpriteVariantStandard? UltraSunUltraMoon { get; set; }

    [JsonPropertyName("lets-go-pikachu-lets-go-eevee")]
    public SpriteVariantStandardWithIconsFrontDefault? LetsGoPikachuLetsGoEevee { get; set; }
}
