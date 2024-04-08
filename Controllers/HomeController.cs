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

    [HttpGet]
    public IActionResult Index(string searchString, string category)
    {
        var products = Repository.Products;

        if (!String.IsNullOrEmpty(searchString))
        {
            ViewBag.SearchString = searchString;
            products = products.Where(p => p.ProductName.ToLower().Contains(searchString)).ToList();
        }

        if (!String.IsNullOrEmpty(category) && category != "0")
        {
            products = products.Where(p => p.CategoryId == int.Parse(category)).ToList();
        }

        // ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name", category);

        var model = new ProductViewModel
        {
            Products = products,
            Categories = Repository.Categories,
            SelectedCategory = category
        };

        return View(model);
    }
    [HttpGet]
    public IActionResult Create()
    {
        ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name");
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(Product model, IFormFile imageFile)
    {
        var allowedExtentions = new[] { "jpg", ".jpeg", ".png" };
        var extension = Path.GetExtension(imageFile.FileName); // dosyanin uzantisini ogrenmek icin orn. asd.jpg (.jpg kismini aliyor.)
        var randomFileName = string.Format($"{Guid.NewGuid()}{extension}"); // dosya adini kaydederken guid ile random bir sey olusturup +extension ile birlestirecek.
        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", imageFile.FileName);
        // path hangi klasore kaydedecegini belirliyorum.
        if (imageFile != null)
        {
            if (!allowedExtentions.Contains(extension))
            {
                ModelState.AddModelError("", "Gecerli bir resim kullaniniz");
            }
        }
        if (ModelState.IsValid)
        {
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await imageFile.CopyToAsync(stream);
            }
            model.Image = randomFileName;
            model.ProductId = Repository.Products.Count + 1;
            Repository.CreateProduct(model);
            return RedirectToAction("Index"); // Index sayfasina dondurmesi icin.
        }
        ViewBag.Categories = new SelectList(Repository.Categories, "CatehoryId", "Name");
        return View(model);

    }
}
