using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class NotificationsController : Controller
    {
        public IActionResult NotificationCreate()
        {
            return View();
        }
        public IActionResult NotificationEdit(int notificationsId)
        {
            ViewBag.NotificationId = notificationsId;
            return View();
        }
        public IActionResult NotificationList()
        {
            return View();
        }
    }
}
