using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class SpriteIconsFrontDefault
{
    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; set; }
}
