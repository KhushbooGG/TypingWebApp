using Microsoft.AspNetCore.Mvc;
using TypingWebApp.TypingData;

namespace TypingWebApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult CourseTyping()
        {
            return View();
        }
        public IActionResult English30BasicHomeKey1()
        {
            English30WPM english30WPM = new English30WPM();
            ViewBag.Letter = english30WPM.listEnglish30BasicHomeKey1[0];

            return View();
        }
        public IActionResult SpeedPassage1()
        {
            return View();
        }
    }
}
