using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class PokemonStat
{
    [JsonPropertyName("base_stat")]
    public int BaseStat { get; set; }

    [JsonPropertyName("effort")]
    public int Effort { get; set; }

    [JsonPropertyName("stat")]
    public Stat Stat { get; set; } = new();
}
