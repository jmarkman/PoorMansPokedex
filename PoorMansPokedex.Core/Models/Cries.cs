using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class Cries
{
    [JsonPropertyName("latest")]
    public string Latest { get; set; } = string.Empty;

    [JsonPropertyName("legacy")]
    public string Legacy { get; set; } = string.Empty;
}
