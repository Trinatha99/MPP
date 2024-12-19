using AdminApi.Models.App;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using AdminApi.DTO.App;
using AdminApi.Models.Helper;
using System.Linq;
using System;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CourseController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Course> _courseRepo;
        private readonly IWebHostEnvironment _enviorment;
        public IConfiguration Configuration { get; }
        public CourseController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Course> courseRepo,
                                IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _courseRepo = courseRepo;
        }

        [HttpPost]
        public ActionResult CreateCourse(CourseDTO courseDTO)
        {
            var objCheck = _context.Courses.SingleOrDefault(opt => opt.CourseName == courseDTO.CourseName && opt.IsDeleted == false);
            try
            {
                if (objCheck == null)
                {

                    Course cour = new Course();
                    cour.CourseName = courseDTO.CourseName;
                    cour.CreatedBy = courseDTO.CreatedBy;
                    var obj = _courseRepo.Insert(cour);
                    return Ok(obj);
                }
                else if (objCheck != null)
                {
                    return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Duplicate Course..!" });
                }
                return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet]
        public ActionResult GetCourseList()
        {
            try
            {
                var list = (from u in _context.Courses
                            select new { u.CourseId,
                                u.CourseName,
                                u.IsDeleted }).Where(x => x.IsDeleted == false);



                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsCoursed = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public ActionResult GetSingleCourse(int id)
        {
            try
            {
                var singleCourse = _courseRepo.SelectById(id);
                return Ok(singleCourse);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult UpdateCourse(UpdateCourseDTO updatecourseDTO)
        {
            try
            {
                var objCourse = _context.Courses.SingleOrDefault(opt => opt.CourseId == updatecourseDTO.CourseId);
                objCourse.CourseName = updatecourseDTO.CourseName;

                objCourse.UpdatedBy = updatecourseDTO.UpdatedBy;
                objCourse.UpdatedOn = System.DateTime.Now;


                _context.SaveChanges();
                return Ok(objCourse);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteCourse(int Id, int DeletedBy)
        {
            try
            {
                var objCourse = _context.Courses.SingleOrDefault(opt => opt.CourseId == Id);
                objCourse.IsDeleted = true;

                objCourse.UpdatedBy = DeletedBy;
                objCourse.UpdatedOn = System.DateTime.Now;


                _context.SaveChanges();
                return Ok(objCourse);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}
