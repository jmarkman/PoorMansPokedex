using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class HeldItem
{
    [JsonPropertyName("item")]
    public Item Item { get; set; } = new();

    [JsonPropertyName("version_details")]
    public List<VersionDetail> VersionDetails { get; set; } = [];
}
