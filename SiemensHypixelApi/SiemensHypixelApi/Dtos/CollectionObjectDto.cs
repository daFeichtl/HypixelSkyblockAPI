using System.Text.Json.Serialization;

namespace ApiTest.Dtos;

public class CollectionObjectDto
{
    /*[JsonPropertyName("success")]
    public bool Success { get; set; }
    [JsonPropertyName("lastUpdated")]
    public long LastUpdated { get; set; }
    [JsonPropertyName("version")]
    public string Version { get; set; }
    [JsonPropertyName("collections")]
    */
    public List<CollectionDto> Collections { get; set; }
}