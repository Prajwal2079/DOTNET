using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tflstore.Models;

namespace tflstore.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(){
        List<Product>  allProducts=ProductManager.GetAllProducts();
        ViewData["catalog"]=allProducts;
        return View();
    }
}