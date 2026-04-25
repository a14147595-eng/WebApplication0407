using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using WebApplication0407.Data;
using WebApplication0407.Models;

namespace WebApplication0407.Controllers
{
    public class AccountController : Controller
    {
        private readonly ProductContext _productContext;
        public AccountController(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User model)
        {
            if (string.IsNullOrEmpty(model.Username) || string.IsNullOrEmpty(model.Password))
            {
                ViewBag.Error = "password or username cant be empty";
                return View(model);
            }
            bool isexist = _productContext.Users.Any(u => u.Username == model.Username);
            if (isexist)
            {
                ViewBag.ReError = "username is already in used";
                return View(model);
            }
            model.Role = "normaluser";
           
            _productContext.Users.Add(model);
            _productContext.SaveChanges();
            return RedirectToAction("Login");
        }
        public IActionResult Login ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User model)
        {
            

            if (string.IsNullOrEmpty(model.Username) || string.IsNullOrEmpty(model.Password))
            {
                ViewBag.Error = "password or username cant be empty";
                return View(model);
            }

            var user = _productContext.Users.FirstOrDefault(u => u.Username == model.Username);
            if (user != null && user.Password == model.Password)
            {
                HttpContext.Session.SetString("User", user.Username!);
                HttpContext.Session.SetString("Role", user.Role ?? "normaluser");
                if (HttpContext.Session.GetString("Role") == "admin")
                {
                    return RedirectToAction("Index", "Products56");
                }


                return RedirectToAction("Index", "Home");
            }
          
            
            ViewBag.Error = "username or password incorrect";
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
        

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("User") == null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
