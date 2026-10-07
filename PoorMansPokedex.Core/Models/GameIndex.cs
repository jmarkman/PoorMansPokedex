using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class GameIndex
{
    [JsonPropertyName("game_index")]
    public int Index { get; set; }

    [JsonPropertyName("version")]
    public Version Version { get; set; } = new();
}
