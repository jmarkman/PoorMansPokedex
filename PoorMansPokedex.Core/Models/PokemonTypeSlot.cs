using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class PokemonTypeSlot
{
    [JsonPropertyName("slot")]
    public int Slot { get; set; }

    [JsonPropertyName("type")]
    public ElementalType Type { get; set; } = new();
}
