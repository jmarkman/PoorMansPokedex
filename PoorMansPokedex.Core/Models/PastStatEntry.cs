using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class PastStatEntry
{
    [JsonPropertyName("generation")]
    public Generation Generation { get; set; } = new();

    [JsonPropertyName("stats")]
    public List<StatEntry> Stats { get; set; } = [];
}
