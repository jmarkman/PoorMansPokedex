using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class Generation2
{
    [JsonPropertyName("gold")]
    public SpriteVariantGeneration2? Gold { get; set; }

    [JsonPropertyName("silver")]
    public SpriteVariantGeneration2? Silver { get; set; }

    [JsonPropertyName("crystal")]
    public SpriteVariantGeneration2Crystal? Crystal { get; set; }
}
