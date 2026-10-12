using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class Generation9
{
    [JsonPropertyName("champions")]
    public SpriteVariantFrontShinyFrontDefault? Champions { get; set; }

    [JsonPropertyName("scarlet-violet")]
    public SpriteVariantFrontFemaleFrontDefault? ScarletViolet { get; set; }
}
