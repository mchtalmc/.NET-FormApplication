using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormApplicationCourse.Models;

namespace FormApplicationCourse.Controllers;

public class HomeController : Controller
{

    public HomeController()
    {

    }

    public IActionResult Index(string searchString)
    {
        var products = Repository.Products;
        if (!string.IsNullOrEmpty(searchString))
        {
            ViewBag.SearchString = searchString;
            products = products.Where(p => p.ProductName.ToLower().Contains(searchString)).ToList();
        }
        return View(products);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
