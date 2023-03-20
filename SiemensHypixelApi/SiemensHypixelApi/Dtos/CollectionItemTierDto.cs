using System.Text.Json.Serialization;

namespace ApiTest.Dtos;

public class CollectionItemTierDto
{
    [JsonPropertyName("tier")]
    public int Tier { get; set; }
    [JsonPropertyName("amountRequired")]
    public int AmountRequired { get; set; }
    [JsonPropertyName("unlocks")]
    public List<object> Unlocks { get; set; }
}