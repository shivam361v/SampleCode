using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStore.Models;
using BOL;
using SAL;

namespace EStore.Controllers;

public class DashboardController : Controller
{
    private readonly ILogger<DashboardController> _logger;

    public DashboardController(ILogger<DashboardController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

     
}
