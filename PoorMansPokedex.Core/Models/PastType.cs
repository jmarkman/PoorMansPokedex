using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class PastType
{
    [JsonPropertyName("generation")]
    public Generation Generation { get; set; } = new();

    [JsonPropertyName("types")]
    public List<PokemonTypeSlot> Types { get; set; } = [];
}
