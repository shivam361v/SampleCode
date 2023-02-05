using Microsoft.AspNetCore.Mvc;
using BOL;

namespace MyRestApp.Controllers;

[ApiController]
[Route("[controller]")]
public class CityController : ControllerBase
{
    private readonly ILogger<CityController> _logger;

    public  CityController(ILogger<CityController> logger)
    {
        _logger = logger;
    }

    public IActionResult GetCitys()
    {
        var citys = new List<City>();
        citys.Add(new City{Name = "Bhopal", CityId = 1, StateId = 1});
        citys.Add(new City{Name = "Pune", CityId = 2, StateId = 2});
        return Ok(citys);
    }

    [Route("{id}")]
    [HttpGet]
    public IActionResult GetCityById(int id)
    {
        var citys = new List<City>();
        Console.WriteLine("Id= "+ id);
        var c = new City{Name = "Pune", CityId = 2, StateId = 2};
        return Ok(c);
    }
}
