using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class Cries
{
    [JsonPropertyName("latest")]
    public string? Latest { get; set; }

    [JsonPropertyName("legacy")]
    public string? Legacy { get; set; }
}
