using Microsoft.AspNetCore.Mvc;
using MVC_jQuery.Models;

namespace MVC_jQuery.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Add authentication logic here...
            return RedirectToAction("Index", "Home");
        }
    }
}
