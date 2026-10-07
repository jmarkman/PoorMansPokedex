using System.Text.Json;
using System.Text.Json.Serialization;

namespace PoorMansPokedex.Core.Models;

public class Generation3
{
    [JsonExtensionData]
    public Dictionary<string, JsonElement> Games { get; set; } = [];
}
