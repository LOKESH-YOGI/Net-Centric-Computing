using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;

namespace MVC_Cookies.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: Account/Login
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Dummy validation (for example only)
            if (username == "admin" && password == "1234")
            {
                // Create cookie options
                CookieOptions options = new CookieOptions
                {
                    Expires = DateTime.Now.AddDays(5), // Cookie valid for 5 days
                    HttpOnly = true, // Prevents client-side script access
                    Secure = true    // Use HTTPS
                };

                // Store user login info in cookie
                Response.Cookies.Append("UserName", username, options);

                ViewBag.Message = "Login successful! Cookie stored for 5 days.";
                return View("Welcome");
            }
            else
            {
                ViewBag.Message = "Invalid username or password.";
                return View();
            }
        }

        // GET: Account/Welcome
        public IActionResult Welcome()
        {
            string username = Request.Cookies["UserName"];
            if (username != null)
            {
                ViewBag.User = username;
                return View();
            }

            return RedirectToAction("Login");
        }

        // Logout Action
        public IActionResult Logout()
        {
            Response.Cookies.Delete("UserName");
            return RedirectToAction("Login");
        }
    }
}
