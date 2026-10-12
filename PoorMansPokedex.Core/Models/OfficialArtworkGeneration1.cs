using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class OfficialArtworkGeneration1
{
    [JsonPropertyName("red-and-blue")]
    public OfficialArtworkVersion? RedAndBlue { get; set; }

    [JsonPropertyName("red-and-green")]
    public OfficialArtworkVersion? RedAndGreen { get; set; }
}
