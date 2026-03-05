using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _2380600637_TruongVietHiep_Buoi4.Models;

namespace _2380600637_TruongVietHiep_Buoi4.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
