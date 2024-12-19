using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class FacultyVideoUploadController : Controller
    {
        public IActionResult FacultyVideoUploadCreate()
        {
            return View();
        }
        public IActionResult FacultyVideoUploadEdit(int facultyVideoUploadId)
        {
            ViewBag.FacultyVideoUploadId = facultyVideoUploadId;
            return View();
        }
        public IActionResult FacultyVideoUploadList()
        {
            return View();
        }
    }
}
