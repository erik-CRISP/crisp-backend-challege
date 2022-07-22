using CRISP.Backend.Challenge.Context;
using CRISP.BackendChallenge.DTO;
using CRISP.BackendChallenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CRISP.BackendChallenge.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    private readonly ILogger<PersonController> _logger;
    private readonly IRepository _repository;

    public PersonController(ILogger<PersonController> logger, IRepository repository)
    {
        _logger = logger;
        _repository = repository;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        _logger.LogDebug(":: Performing {MethodName}", nameof(GetAll));
        var result = _repository.Query<Person>()
            .ToList().Select(x => new PersonResponse
            {
                Id = x.Id,
                Name = x.Name,
                // TODO: Include the login date information...
                LoginDates = null
            });
        return Ok(result);
    }
}