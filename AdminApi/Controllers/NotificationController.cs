using AdminApi.Models.App;
using AdminApi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.DTO.App;
using AdminApi.Models.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using static Org.BouncyCastle.Math.EC.ECCurve;
using System.Linq;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class NotificationController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Notifications> _notificationsRepo;
        private readonly IWebHostEnvironment _enviorment;
        public IConfiguration Configuration { get; }
        public NotificationController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Notifications> notificationRepo
                               )
        {
            _config = config;
            _context = context;
            _notificationsRepo = notificationRepo;
        }

        [HttpPost]
        public ActionResult CreateNotifications(NotificationsDTO notificationsDTO)
        {
           
            var objCheck = _context.GetNotifications.SingleOrDefault(opt => opt.Description == notificationsDTO.Description && opt.IsDeleted == false);
            try
            {
                if (objCheck == null)
                {

                    Notifications not = new Notifications();
                    not.NotificationName = notificationsDTO.NotificationName;
                    not.Description = notificationsDTO.Description;
                    not.Image = notificationsDTO.Image;
                    not.CreatedBy = notificationsDTO.CreatedBy;
                    not.CreatedOn = DateTime.Now;
                    var obj = _notificationsRepo.Insert(not);
                    return Ok(obj);
                }
                else if (objCheck != null)
                {
                    return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Duplicate Notifications..!" });
                }
                return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetNotificationsList()
        {
            try
            {
                var list = (from u in _context.GetNotifications
                            select new { u.NotificationsId,
                                u.NotificationName,
                                u.Description,
                                u.Image,
                                u.IsDeleted }).Where(x => x.IsDeleted == false);

                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsNotified = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public ActionResult GetSingleNotifications(int id)
        {
            try
            {
                var singleNotifications = _notificationsRepo.SelectById(id);
                return Ok(singleNotifications);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult UpdateNotifications(UpdateNotificationsDTO updateNotificationsDTO)
        {
            try
            {
                var objNotifications = _context.GetNotifications.SingleOrDefault(opt => opt.NotificationsId == updateNotificationsDTO.NotificationsId);
                objNotifications.NotificationName = updateNotificationsDTO.NotificationName;
                objNotifications.Description = updateNotificationsDTO.Description;
                objNotifications.Image = updateNotificationsDTO.Image;
                objNotifications.UpdatedBy = updateNotificationsDTO.UpdatedBy;
                objNotifications.UpdatedOn = System.DateTime.Now;


                _context.SaveChanges();
                return Ok(objNotifications);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteNotifications(int Id, int DeletedBy)
        {
            try
            {
                var objNotifications = _context.GetNotifications.SingleOrDefault(opt => opt.NotificationsId == Id);
                objNotifications.IsDeleted = true;

                objNotifications.UpdatedBy = DeletedBy;
                objNotifications.UpdatedOn = System.DateTime.Now;


                _context.SaveChanges();
                return Ok(objNotifications);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

    }
}

