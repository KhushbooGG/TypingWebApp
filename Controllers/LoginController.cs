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

            // Student Login
            if (user!=null)
            {
                return RedirectToAction("Dashboard", "Student");
            }
            else
            {
                ViewBag.Message = "Invalid Username or Password";
                return View("Index");
            }
            
        }
    }
}
