using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GrosseryStore.Models;
using BOL;
using BLL;

namespace GrosseryStore.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    // public IActionResult Details(int id)
    // {
    //     Product prod = ProductManager.GetProductById(id);
    //     this.ViewData["details"] = prod;
    //     return View();
    // }

    public IActionResult Display(){
        this.ViewData["details"] = ProductManager.GetAllProducts();
        return View();
    }

    public IActionResult DisplayForm(){
        return View();
    }


    public IActionResult Insert(){
        Product newProduct = new Product();
        ProductManager.InsertProduct(newProduct);
        return Redirect("Display");
    }

}