using AspDotNetViewsTuneUp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetViewsTuneUp.Controllers;

public class HomeController : Controller
{
    [Route("/")]
    [Route("home")]
    public IActionResult Index()
    {
        return View();
    }

    [Route("about-company")]
    public IActionResult About()
    {
        return View();
    }

    [Route("contact-support")]
    public IActionResult Contacts()
    {
        return View();
    }
}
