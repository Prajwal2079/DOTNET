using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UserPortal.Models;
using UsersInformation;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace UserPortal.Controllers;

public class HomeController : Controller
{
    string fileName = @"e:\userlist.json";
    List<Users> userlist = new List<Users>();
    List<Users> userSavedList = new List<Users>();
    bool flag;

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Validate(string email, string password)
    {
        string userjsonFile = System.IO.File.ReadAllText(fileName);
        userlist = JsonSerializer.Deserialize<List<Users>>(userjsonFile);
        foreach (Users user in userlist)
        {
            Console.WriteLine("In for each");
            if (user.Email == email && user.Password == password)
            {
                Console.WriteLine("Welcome");
                flag = true;
                return Redirect("/home/Index");
            }
            else
            {
                return Redirect("/home/Error");
            }
        }
        Console.WriteLine(userlist);
       
        return Redirect("/home/Register");
    }


    public IActionResult Registered(string fname, string lname, string email, string mobno, string password)
    {
        string userjsonFile = System.IO.File.ReadAllText(fileName);
        userlist = JsonSerializer.Deserialize<List<Users>>(userjsonFile);
        // userlist = userSavedList;

        var user = new Users(fname, lname, email, mobno, password);
        userlist.Add(user);

        var usersJson = JsonSerializer.Serialize<List<Users>>(userlist);
        System.IO.File.WriteAllText(fileName, usersJson);
        Console.WriteLine("Registered succesfully");

        return Redirect("/home/Index");

    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }




}
