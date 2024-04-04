using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormApplicationCourse.Models;

namespace FormApplicationCourse.Controllers;

public class HomeController : Controller
{

    public HomeController()
    {

    }

    public IActionResult Index()
    {
        return View(Repository.Products);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
