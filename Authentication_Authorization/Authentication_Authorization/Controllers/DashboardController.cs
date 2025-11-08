using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Authentication_Authorization.Controllers
{
    public class DashboardController : Controller
    {
        // Accessible only by Admin role
        [Authorize(Roles = "Admin")]
        public IActionResult Admin()
        {
            return View();
        }
        // Accessible only by Users role
        [Authorize(Roles = "User")]
        public IActionResult User()
        {
            return View();
        }
        // Accessible by Admin and User role
        [Authorize(Roles = "Admin, User")]
        public IActionResult Common()
        {
            return View();
        }
    }
}
