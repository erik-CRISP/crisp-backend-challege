using CRISP.Backend.Challenge.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRISP.Backend.Challenge.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{

    private readonly ILogger<PersonController> _logger;

    public PersonController(ILogger<PersonController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("[action]")]
    public IActionResult Person()
    {
        return Ok(new List<Person>());
    }
}