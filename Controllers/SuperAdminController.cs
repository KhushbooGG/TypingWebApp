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
            string InstituteName = Request.Form["Institutename"];
            string PrincipalName = Request.Form["principalname"];
            string InstituteAddress = Request.Form["institutename"];
          
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
