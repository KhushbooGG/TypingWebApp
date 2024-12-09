using Microsoft.AspNetCore.Mvc;
using TypingWebApp.Models;

namespace TypingWebApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly dbContext _context;
        public LoginController(dbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LoginUser()
        {
            string UserName = Request.Form["username"];
            string Password = Request.Form["password"];

            var user = _context.Users.Where(u => u.Username == UserName && u.Password == Password && u.IsActive == true).FirstOrDefault();

            if (user != null)
            {
                if (user.RoleId == 1)
                {
                    // Student Login
                    return RedirectToAction("Dashboard", "Student");
                }else if (user.RoleId == 3)
                {
                    // Super Admin Login
                    return RedirectToAction("Index", "SuperAdmin");
                }
                else
                {
                    ViewBag.Message = "Invalid Login!";
                    return View("Index");
                }
            }
            else
            {
                ViewBag.Message = "Invalid Username or Password!";
                return View("Index");
            }

        }
    }
}
