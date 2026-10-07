using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class PokemonMoveVersionGroupDetail
{
    [JsonPropertyName("level_learned_at")]
    public int LevelLearnedAt { get; set; }

    [JsonPropertyName("version_group")]
    public VersionGroup VersionGroup { get; set; } = new();

    [JsonPropertyName("move_learn_method")]
    public MoveLearnMethod MoveLearnMethod { get; set; } = new();

    [JsonPropertyName("order")]
    public int? Order { get; set; }
}
