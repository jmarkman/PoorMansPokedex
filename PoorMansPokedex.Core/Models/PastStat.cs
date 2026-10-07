using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class PastStat
{
    [JsonPropertyName("generation")]
    public Generation Generation { get; set; } = new();

    [JsonPropertyName("stats")]
    public List<PokemonStat> Stats { get; set; } = [];
}
