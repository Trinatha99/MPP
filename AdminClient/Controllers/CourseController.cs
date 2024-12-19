using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult CourseCreate()
        {
            return View();
        }
        public IActionResult CourseEdit(int courseid)
        {
            ViewBag.courseid = courseid;
            return View();
        }
        public IActionResult CourseList()
        {
            return View();
        }
    }
}
