using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class GalleryCategoryController : Controller
    {
        public IActionResult GalleryCategoryCreate()
        {
            return View();
        }
        public IActionResult GalleryCategoryEdit(int galleryCategoryId)
        {
            ViewBag.GalleryCategoryId = galleryCategoryId;
            return View();
        }
        public IActionResult GalleryCategoryList()
        {
            return View();
        }
    }
}
