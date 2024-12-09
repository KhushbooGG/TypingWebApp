using Microsoft.AspNetCore.Mvc;

namespace TypingWebApp.Controllers
{
    public class SuperAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddInstitute()
        {
            return View();
        }

        public IActionResult InstituteReport()
        {
            return View();
        }

        public IActionResult StudentReport()
        {
            return View();
        }

        public IActionResult InstructorReport()
        {
            return View();
        }
    }
}
