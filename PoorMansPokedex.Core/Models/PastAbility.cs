using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class PastAbility
{
    [JsonPropertyName("generation")]
    public Generation Generation { get; set; } = new();

    [JsonPropertyName("abilities")]
    public List<PokemonAbility> Abilities { get; set; } = [];
}
