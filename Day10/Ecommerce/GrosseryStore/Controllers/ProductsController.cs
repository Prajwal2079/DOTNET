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

    public IActionResult Details(int id)
    {
        Product prod = ProductManager.GetProductById(id);
        this.ViewData["details"] = prod;
        return View();
    }

    public IActionResult Display(){
        this.ViewData["details"] = ProductManager.GetAllProducts();
        return View();
    }

    public IActionResult DisplayForm(){
        return View();
    }


    public IActionResult Insert(string prodId,string prodName,string price,string avlbUnits){
        Product newProduct = new Product(Convert.ToInt32(prodId), prodName, Convert.ToDouble(price), Convert.ToInt32(avlbUnits));
        ProductManager.InsertProduct(newProduct);
        return Redirect("Display");
    }

}