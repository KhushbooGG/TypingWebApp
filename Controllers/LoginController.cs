using Microsoft.AspNetCore.Mvc;

namespace TypingWebApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LoginUser()
        {
            string UserName = Request.Form["username"];
            string Password = Request.Form["password"];

            // Student Login
            if (UserName == "admin" && Password == "admin123")
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
