using Microsoft.AspNetCore.Mvc;
using SINOP.Application.Interfaces;
using SINOP.Domain.Entitys;

namespace SINOP.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SeloController : ControllerBase
{
    private readonly ISeloAppService _seloAppService;

    public SeloController(ISeloAppService seloAppService)
    {
        _seloAppService = seloAppService;
    }

    [HttpGet("list")]
    public async Task<ActionResult<List<Selo>>> GetAll()
    {
        try
        {
            var response = await _seloAppService.GetAll();
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }

    [HttpGet]
    public async Task<ActionResult<Selo>> GetById([FromQuery] int seloId)
    {
        try
        {
            var response = await _seloAppService.GetById(seloId);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }

    [HttpPost]
    public async Task Post([FromBody] Selo selo)
    {
        try
        {
            await _seloAppService.Add(selo);
        }
        catch (Exception ex)
        {
            BadRequest(ex);
        }
    }

    [HttpPut]
    public async Task Put([FromBody] Selo selo)
    {
        try
        {
            await _seloAppService.Update(selo);
        }
        catch (Exception ex)
        {
            BadRequest(ex);
        }
    }

    [HttpDelete]
    public async Task Delete([FromBody] Selo selo)
    {
        try
        {
            await _seloAppService.Delete(selo);

        }
        catch (Exception ex)
        {
            BadRequest(ex);
        }
    }
}