using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class OtherSprites
{
    [JsonPropertyName("home")]
    public Home Home { get; set; } = new();

    [JsonPropertyName("showdown")]
    public Showdown Showdown { get; set; } = new();

    [JsonPropertyName("dream_world")]
    public DreamWorld DreamWorld { get; set; } = new();

    [JsonPropertyName("official-artwork")]
    public OfficialArtwork OfficialArtwork { get; set; } = new();
}
