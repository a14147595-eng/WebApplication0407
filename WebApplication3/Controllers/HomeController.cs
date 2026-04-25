using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication0407.Models;

namespace WebApplication0407.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("User")))
            {
                return RedirectToAction("Register", "Account");
            }
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
}
