using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStore.Models;
using BOL;
using SAL;

namespace EStore.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        ProductHubService svc   =  new ProductHubService();
          List<Product> allProducts = svc.GetAllProducts ( );
        this.ViewBag.catalog=allProducts; 
        TempData["data"]="Index view of Products";
        return View();
    }

    [HttpGet]
    public IActionResult Details(int id)
    {  
        System.Console.WriteLine(id);
        ProductHubService svc = new ProductHubService();
        Product product = svc.GetProductById(id);  
        Console.WriteLine(product.Title + " " + product.ProductId);
        ViewBag.currentProduct = product;
        return View();
    }

     
}
