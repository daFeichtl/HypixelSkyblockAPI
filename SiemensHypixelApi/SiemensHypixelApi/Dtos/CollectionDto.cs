using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ApiTest.Dtos;

public class CollectionDto
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("items")]
    public List<CollectionItemDto> Items { get; set; }
}