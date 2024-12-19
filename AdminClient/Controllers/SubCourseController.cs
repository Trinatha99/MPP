using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class SubCourseController : Controller
    {
        public IActionResult SubCourseCreate()
        {
            return View();
        }
        public IActionResult SubCourseEdit(int subcourseid)
        {
            ViewBag.subcourseid = subcourseid;
            return View();
        }
        public IActionResult SubCourseList()
        {
            return View();
        }
    }
}
