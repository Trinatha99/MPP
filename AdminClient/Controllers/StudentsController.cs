using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult StudentsCreate()
        {
            return View();
        }
        public IActionResult StudentsEdit(int studentsId)
        {
            ViewBag.StudentsId = studentsId;
            return View();
        }
        public IActionResult StudentsList()
        {
            return View();
        }
    }
}
