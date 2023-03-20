using System.Text.Json.Serialization;

namespace ApiTest.Dtos;

public class CollectionItemDto
{ [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("maxTiers")]
    public int MaxTiers { get; set; }
    [JsonPropertyName("tiers")]
    public List<CollectionItemTierDto> Tiers { get; set; }
}