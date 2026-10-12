using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class VersionDetail
{
    [JsonPropertyName("rarity")]
    public int Rarity { get; set; }

    [JsonPropertyName("version")]
    public Version Version { get; set; } = new();
}
