using System.Text.Json.Serialization;

namespace ApiTest.Dtos;

public class ItemReturnDto
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }
    [JsonPropertyName("lastUpdated")]
    public long LastUpdated { get; set; }
    [JsonPropertyName("items")]
    public List<ItemDto> Items { get; set; }
}