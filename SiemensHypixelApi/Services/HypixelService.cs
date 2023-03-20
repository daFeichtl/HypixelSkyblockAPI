using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ApiTest.Dtos;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace ApiTest.Services;

public class HypixelService
{
    private readonly string apiUrl = @"https://api.hypixel.net";
    private readonly RestClient _client;

    public HypixelService(IConfiguration configuration)
    {
        var key = configuration.GetSection("KeyConfig").GetSection("ApiKey").Value;  

        if (key == null)
        {
            Console.WriteLine("OIS KAPUTT!");
        }
        _client = new RestClient(apiUrl);
        _client.AddDefaultHeader("API-Key", key);
    }
    
    private string? LoadApiKey()
    {
        var keyLocation = @"key/api-key";
        try
        {
            return File.ReadAllLines(keyLocation)[0];
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }

    public async Task<List<CollectionDto>?> GetCollections()
    {
        var request = new RestRequest("/resources/skyblock/collections");
        var response = await _client.ExecuteAsync(request);
        return ParseCollection(response.Content!)?.Collections;
    }

    public async Task<List<ItemDto>?> GetAllItems()
    {
        var reqest = new RestRequest("/resources/skyblock/items");
        var response = await _client.ExecuteAsync<ItemReturnDto>(reqest);
        return response.Data?.Items;
    }

    public List<ItemDto>? GetAllAccessories()
    {
        return GetAllItems().Result?.Where(x => x.Category?.ToLower().Contains("accessory") == true).ToList();
    }

    public CollectionObjectDto? ParseCollection(string input)
    {
        var collections = input.Split("collections\":")[1];
        collections = collections.Substring(0, collections.Length - 1);
        var obj = JObject.Parse(collections);
        var collArr = new JArray();
        foreach (var coll in obj)
        {
            var collectionName = coll.Value;
            var itemsArray = new JArray();
            if (collectionName != null)
            {
                var collItems = collectionName.Last!.Children().First().Values<JProperty>();
                foreach (var item in collItems)
                {
                    itemsArray.Add(item.Value);
                }
                collArr.Add(new JObject(new JProperty("name", coll.Key.ToLower()),
                                        new JProperty("items", itemsArray)));
            }
        }
        
        var json = new JObject(new JProperty("collections", collArr)).ToString();
        var dto = JsonConvert.DeserializeObject<CollectionObjectDto>(json);
        return dto;
    }
}