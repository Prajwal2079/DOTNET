using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tflstore.Models;

namespace tflstore.Controllers;

public class AuthController : Controller
{
    private readonly ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

    public IActionResult Validate(string email, string password)
    {
        User user = new User(email, password);
        user = UserManager.AuthenticateUser(user);
        if( user != null){
            ViewData["currentUser"]=user;
            return View("Dashboard");
        }
        else{
            Console.WriteLine("User is null");
            return Redirect("/Auth/Login");
        }
    }

    public IActionResult Dashboard()
    {
        return View();
    }

    public IActionResult Postregister(string number, string name, string email, string password)
    {
        User user = new User(name, number, email, password);
        UserManager.SaveUser(user);
        return Redirect("/Home/Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
