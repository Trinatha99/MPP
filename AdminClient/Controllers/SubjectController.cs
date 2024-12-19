using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class SubjectController : Controller
    {
        public IActionResult SubjectCreate()
        {
            return View();
        }
        public IActionResult SubjectEdit(int subjectId)
        {
            ViewBag.SubjectId = subjectId;
            return View();
        }
        public IActionResult SubjectList()
        {
            return View();
        }
    }
}
