using Newtonsoft.Json;

namespace ApiTest.Dtos;

public class ApiKeyDto
{
    [JsonProperty("success")]
    public bool Success { get; set; }
    [JsonProperty("record")]
    public ApiKeyRecord? Record { get; set; }
    [JsonProperty("cause")]
    public string? Cause { get; set; }
    [JsonProperty("throttle")]
    public bool? Throttle { get; set; }
    [JsonProperty("global")]
    public bool? Global { get; set; }
}

public class ApiKeyRecord
{
    [JsonProperty("key")]
    public string Key { get; set; }
    [JsonProperty("owner")]
    public string Owner { get; set; }
    [JsonProperty("limit")]
    public int Limit { get; set; }
    [JsonProperty("queriesInPastMin")]
    public int QueriesInPastMin { get; set; }
    [JsonProperty("totalQueries")]
    public int TotalQueries { get; set; }
}