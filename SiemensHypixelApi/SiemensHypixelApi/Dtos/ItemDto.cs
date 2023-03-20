using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

namespace ApiTest.Dtos;

public class ItemDto
{
    [JsonPropertyName("material")]
    public string? Material { get; set; }
    [JsonPropertyName("color")]
    public string? Color { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("category")]
    public string? Category { get; set; }
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
    [JsonPropertyName("stats")]
    public object? Stats { get; set; }
    [JsonPropertyName("npc_sell_price")]
    public double? NpcSellPrice { get; set; }
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}