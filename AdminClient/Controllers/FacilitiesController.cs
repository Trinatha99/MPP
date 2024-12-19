using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class FacilitiesController : Controller
    {
        public IActionResult FacilitiesCreate()
        {
            return View();
        }
        public IActionResult FacilitiesEdit(int facilitiesId)
        {
            ViewBag.FacilitiesId = facilitiesId;
            return View();
        }
        public IActionResult FacilitiesList()
        {
            return View();
        }
    }
}
