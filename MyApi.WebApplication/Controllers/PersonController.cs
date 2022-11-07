using Microsoft.AspNetCore.Mvc;
using MyApi.Application.DTOs;
using MyApi.Application.Services.Interfaces;

namespace MyApi.WebApplication.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class PersonController : ControllerBase
{
    private readonly IPersonService _personService;
    
    public PersonController(IPersonService personService)
    {
        _personService = personService;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] PersonDTO personDto)
    {
        var result = await _personService.CreateAsync(personDto);
        if (result.IsSuccess)
            return Ok(result);
        return BadRequest(result);
    }
}