using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult TeacherCreate()
        {
            return View();
        }
        public IActionResult TeacherEdit(int TeacherId)
        {
            ViewBag.TeacherId = TeacherId;
            return View();
        }
        public IActionResult TeacherList()
        {
            return View();
        }
    }
}
