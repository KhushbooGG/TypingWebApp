using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TypingWebApp.Models;

namespace TypingWebApp.Controllers
{
    public class SuperAdminController : Controller
    {
        private readonly dbContext _context;
        public SuperAdminController(dbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SaveInstitute()
        {
            string InstituteName = Request.Form["Institutename"];
            string PrincipalName = Request.Form["principalname"];
            string InstituteAddress = Request.Form["institutename"];
            string InstituteCode = Request.Form["institutecode"];
            string Contactno = Request.Form["contactno"];
            string Emailid = Request.Form["emailid"];
            string Noofcomputerinlab = Request.Form["noofcomputerinlab"];
            string Principalimage = Request.Form["principalimage"];
            string Instituteimage = Request.Form["instituteimage"];
            string status = Request.Form["status"];

            Institute institute = new Institute();
            institute.InstituteName = InstituteName;
            institute.PrincipalName = PrincipalName;
            institute.InstituteAddress = InstituteAddress;
            institute.InstituteCode = InstituteCode;
            institute.ContactNo = Contactno;
            institute.Email = Emailid;
            institute.NoOfComputer = Convert.ToInt32(Noofcomputerinlab);
            institute.PrincipalPhotoUrl = Principalimage;
            institute.InstituteSymbolUrl = Instituteimage;
            institute.Status = status;
            _context.Institute.Add(institute);
            _context.SaveChanges();
            return RedirectToAction("InstituteReport");
        }

        public IActionResult AddInstitute()
        {

            return View();
        }

        public IActionResult InstituteReport()
        {
            var report = _context.Institute.ToList();
            return View(report);


        }

        public IActionResult StudentReport()
        {
            var report = _context.Students.ToList();
            return View(report);
        }

        public IActionResult InstructorReport()
        {
            var instructorreport = _context.Instructor.ToList();
            return View(instructorreport);
        }
        public IActionResult AddNotice()
        {
            var user = _context.Users.ToList();
            List<SelectListItem> list = new List<SelectListItem>();
            foreach (var item in user)
            {
                list.Add(new SelectListItem(item.Username, item.Id.ToString()));
            }

            TempData["UsersList"] = list;
          
            return View();
        }
        public IActionResult SaveNotice()
        {
            var touserid=Request.Form["ToUserId"];
            var noticetext = Request.Form["NoticeText"];
            Notice notice = new Notice();
            notice.ToUserId = Convert.ToInt32(touserid);
            notice.NoticeText = noticetext;
            _context.Notice.Add(notice);
            _context.SaveChanges();

            return View();
        }

    }
}

