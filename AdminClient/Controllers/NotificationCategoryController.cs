using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class NotificationCategoryController : Controller
    {
        public IActionResult NotificationCategoryCreate()
        {
            return View();
        }
        public IActionResult NotificationCategoryEdit(int NotificationCategoryId)     
        {
            ViewBag.NotificationCategoryId = NotificationCategoryId;
            return View();
        }
        public IActionResult NotificationCategoryList()
        {
            return View();
        }
       
    }
}
