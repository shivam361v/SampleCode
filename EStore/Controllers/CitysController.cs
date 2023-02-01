using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStore.Models;
using BOL;
using SAL;

namespace EStore.Controllers;

public class CitysController : Controller
{
    private readonly ILogger<CitysController> _logger;

    public CitysController(ILogger<CitysController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        CityHubService svc   =  new CityHubService();
          List<City> allCitys = svc.GetAllCitys ( );
        this.ViewBag.catalog = allCitys; 
        TempData["data"]="Index view of Citys";
        return View();
    }

     
}
