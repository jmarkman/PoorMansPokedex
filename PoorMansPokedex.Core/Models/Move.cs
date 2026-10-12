using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class Move
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("url")]
    public string Url { get; set; } = string.Empty;
}
