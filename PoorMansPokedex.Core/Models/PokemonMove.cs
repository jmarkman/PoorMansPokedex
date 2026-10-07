using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class PokemonMove
{
    [JsonPropertyName("move")]
    public Move Move { get; set; } = new();

    [JsonPropertyName("version_group_details")]
    public List<PokemonMoveVersionGroupDetail> VersionGroupDetails { get; set; } = [];
}
