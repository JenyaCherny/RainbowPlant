using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace RainbowPlant.Controllers;

public class PlantController : Controller
{
    // 
    // GET: /Plant/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /Plant/Welcome/ 
    public string Welcome()
    {
        return "This is the Welcome action method...";
    }
}