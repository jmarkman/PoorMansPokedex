using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class PokedexEntry
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("base_experience")]
    public int BaseExperience { get; set; }

    [JsonPropertyName("height")]
    public int Height { get; set; }

    [JsonPropertyName("is_default")]
    public bool IsDefault { get; set; }

    [JsonPropertyName("order")]
    public int Order { get; set; }

    [JsonPropertyName("weight")]
    public int Weight { get; set; }

    [JsonPropertyName("location_area_encounters")]
    public string LocationAreaEncounters { get; set; } = string.Empty;

    [JsonPropertyName("abilities")]
    public List<PokemonAbility> Abilities { get; set; } = [];

    [JsonPropertyName("past_abilities")]
    public List<PastAbility> PastAbilities { get; set; } = [];

    [JsonPropertyName("forms")]
    public List<Form> Forms { get; set; } = [];

    [JsonPropertyName("game_indices")]
    public List<GameIndex> GameIndices { get; set; } = [];

    [JsonPropertyName("held_items")]
    public List<HeldItem> HeldItems { get; set; } = [];

    [JsonPropertyName("moves")]
    public List<PokemonMove> Moves { get; set; } = [];

    [JsonPropertyName("species")]
    public Species Species { get; set; } = new();

    [JsonPropertyName("sprites")]
    public Sprites Sprites { get; set; } = new();

    [JsonPropertyName("cries")]
    public Cries Cries { get; set; } = new();

    [JsonPropertyName("stats")]
    public List<PokemonStat> Stats { get; set; } = [];

    [JsonPropertyName("past_stats")]
    public List<PastStat> PastStats { get; set; } = [];

    [JsonPropertyName("types")]
    public List<PokemonTypeSlot> Types { get; set; } = [];

    [JsonPropertyName("past_types")]
    public List<PastType> PastTypes { get; set; } = [];
}
