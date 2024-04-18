using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc_app.Models;

namespace mvc_app.Controllers;

public class HomeController : Controller
{
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

    [HttpPost]
    public async Task<IActionResult> Index(UserModel model)
    {
        if (!ModelState.IsValid)
            return View(model);

        return RedirectToAction("Index", "Profile", new { username = model.Username });
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}