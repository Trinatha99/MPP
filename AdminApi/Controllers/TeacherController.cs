using AdminApi.Models.App;
using AdminApi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.DTO.App;
using AdminApi.Models.Helper;
using System;
using System.Linq;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TeacherController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Teacher> _teacherRepo;
        private readonly IWebHostEnvironment _enviorment;


        public TeacherController(IConfiguration config,
                              AppDbContext context,
                              ISqlRepository<Teacher> teacherRepo,
                              IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _teacherRepo = teacherRepo;
        }

        [HttpPost]

        public ActionResult CreateTeacher(TeacherDTO teacherDTO)
        {

            try
            {

                Teacher cour = new Teacher();
                cour.CourseId = teacherDTO.CourseId;
                cour.SubCourseId = teacherDTO.SubCourseId;
                cour.SubjectId = teacherDTO.SubjectId;
                cour.TeacherName = teacherDTO.TeacherName;
                cour.TeacherDetails = teacherDTO.TeacherDetails;
                cour.TeacherImage = teacherDTO.TeacherImage;


                cour.CreatedBy = teacherDTO.CreatedBy;
                var obj = _teacherRepo.Insert(cour);
                return Ok(obj);

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }




        [HttpGet]
        public ActionResult GetTeacherList()
        {
            try
            {
                var list = (from u in _context.Teachers
                            join a in _context.Courses on u.CourseId equals a.CourseId
                            join b in _context.SubCourses on u.SubCourseId equals b.SubCourseId
                            join c in _context.Subjects on u.SubjectId equals c.SubjectId
                            select new
                            {
                                u.CourseId,
                                a.CourseName,
                                u.SubCourseId,
                                b.SubCourseName,
                                u.SubjectId,
                                c.SubjectName,
                                u.TeacherName,
                                u.TeacherDetails,
                                u.TeacherImage,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false);



                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsCoursed = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet("{id}")]
        public ActionResult GetSingleTeacher(int id)
        {
            try
            {
                var singleTeacher = _teacherRepo.SelectById(id);
                return Ok(singleTeacher);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult UpdateTeacher(UpdateTeacherDTO updateTeacherDTO)
        {
            try
            {
                var objCourse = _context.Teachers.SingleOrDefault(opt => opt.TeacherId == updateTeacherDTO.TeacherId);
                objCourse.CourseId = updateTeacherDTO.SubCourseId;
                objCourse.SubCourseId = updateTeacherDTO.SubCourseId;
                objCourse.SubjectId = updateTeacherDTO.SubCourseId;
                objCourse.TeacherName = updateTeacherDTO.TeacherName;
                objCourse.TeacherDetails = updateTeacherDTO.TeacherDetails;
                objCourse.TeacherImage = updateTeacherDTO.TeacherImage;
                objCourse.UpdatedBy = updateTeacherDTO.UpdatedBy;
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
        public ActionResult DeleteTeacher(int Id, int DeletedBy)
        {
            try
            {
                var objCourse = _context.Teachers.SingleOrDefault(opt => opt.TeacherId == Id);
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

        [HttpGet("{SubjectId}")]
        public ActionResult GetTeacherListbySubjectId(int SubjectId)
        {
            try
            {
                var list = (from u in _context.Teachers
                            join a in _context.Subjects on u.SubjectId equals a.SubjectId


                            select new
                            {
                                u.TeacherId,
                                u.TeacherName,
                                u.TeacherImage,
                                u.SubjectId,
                                a.SubjectName,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.SubjectId == SubjectId).Distinct().ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}
