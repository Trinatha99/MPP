using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult GalleryCreate()
        {
            return View();
        }
        public IActionResult GalleryEdit(int galleryId)
        {
            ViewBag.GalleryId = galleryId;
            return View();
        }
        public IActionResult GalleryList()
        {
            return View();
        }
    }
}
