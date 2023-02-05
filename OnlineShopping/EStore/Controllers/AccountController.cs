using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStore.Models;

namespace EStore.Controllers;

public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;

    public AccountController(ILogger<AccountController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(String email, String password)
    {
        if(email ==  "shivam361v@gmail.com" && password == "123")
        {
            Console.WriteLine("Login form working");
            Response.Redirect("/orders/index");
        }
        return View();
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }


    [HttpPost]
    public IActionResult Register(string firstname, string lastname, string  location,string email, string password)
    {
        Console.WriteLine(firstname + " " + lastname + " "+ location);
        return this.RedirectToAction("Login","Account");
    }

}
