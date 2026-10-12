using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class GameIndexEntry
{
    [JsonPropertyName("game_index")]
    public int GameIndexNumber { get; set; }

    [JsonPropertyName("version")]
    public Version Version { get; set; } = new();
}
