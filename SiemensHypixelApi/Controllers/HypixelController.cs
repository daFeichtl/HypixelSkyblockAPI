using System.Threading.Tasks;
using ApiTest.Dtos;
using ApiTest.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiTest.Controllers;

[ApiController]
[Route("hypixel")]
public class HypixelController
{
    private readonly HypixelService _service;

    public HypixelController(HypixelService service)
    {
        _service = service;
    }

    [HttpGet("collections")]
    public async Task<ActionResult<List<CollectionDto>?>> GetCollections()
    {
        return await _service.GetCollections();
    }

    [HttpGet("items")]
    public async Task<ActionResult<List<ItemDto>?>> GetAllItems()
    {
        return await _service.GetAllItems();
    }

    [HttpGet("accessories")]
    public ActionResult<List<ItemDto>?> GetAllAccessories()
    {
        return _service.GetAllAccessories();
    }

    [HttpGet("apiKeyCheck")]
    public async Task<ActionResult<bool>> ApiKeyCheck([FromBody] string apiKey)
    {
        return await _service.ApiKeyCheck(apiKey);
    }
}