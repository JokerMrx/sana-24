using Microsoft.AspNetCore.Mvc;
using mvc_app.Models;

namespace mvc_app.Controllers;

public class ProfileController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public ProfileController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index(string username)
    {
        var user = new UserModel { Username = username };
        return View(user);
    }
}