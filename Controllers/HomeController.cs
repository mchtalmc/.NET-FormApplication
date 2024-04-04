using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormApplicationCourse.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FormApplicationCourse.Controllers;

public class HomeController : Controller
{

    public HomeController()
    {

    }

    public IActionResult Index(string searchString, string category)
    {
        var products = Repository.Products;
        if (!string.IsNullOrEmpty(searchString))
        {
            ViewBag.SearchString = searchString;
            products = products.Where(p => p.ProductName.ToLower().Contains(searchString)).ToList();
        }
        if (!string.IsNullOrEmpty(category) && category != "0")
        {
            products = products.Where(p => p.CategoryId == int.Parse(category)).ToList();
        }
        ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "CategoryName");
        return View(products);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
