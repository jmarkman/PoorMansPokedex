using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class SpriteIconsFrontFemaleFrontDefault
{
    [JsonPropertyName("front_female")]
    public string? FrontFemale { get; set; }

    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; set; }
}
