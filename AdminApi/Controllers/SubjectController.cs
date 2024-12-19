using AdminApi.Models.App;
using AdminApi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.DTO.App;
using AdminApi.Models.Helper;
using System.Linq;
using System;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class SubjectController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Subject> _subjectRepo;
        private readonly IWebHostEnvironment _enviorment;


        public SubjectController(IConfiguration config,
                               AppDbContext context,
                               ISqlRepository<Subject> subjectRepo,
                               IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _subjectRepo = subjectRepo;
        }

        [HttpPost]
        public ActionResult CreateSubject(SubjectDTO subjectDTO)
        {
           
            try
            {
               
                    Subject cour = new Subject();
                    cour.CourseId=subjectDTO.CourseId;
                    cour.SubCourseId = subjectDTO.SubCourseId;
                    cour.SubjectName = subjectDTO.SubjectName;
                    cour.SubjectDetails = subjectDTO.SubjectDetails;
                    cour.SubjectImage= subjectDTO.SubjectImage;


                    cour.CreatedBy = subjectDTO.CreatedBy;
                    var obj = _subjectRepo.Insert(cour);
                    return Ok(obj);
               
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

         [HttpGet]
        public ActionResult GetSubjectList()
        {
            try
            {
                var list = (from u in _context.Subjects
                            join b in _context.Courses on u.CourseId equals b.CourseId
                            join a in _context.SubCourses on u.SubCourseId equals a.SubCourseId
                            select new { 
                                u.SubjectId,
                                u.CourseId,
                                b.CourseName,
                                u.SubCourseId,
                                a.SubCourseName,
                                u.SubjectName,
                                u.SubjectDetails,
                                u.SubjectImage,
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
        public ActionResult GetSingleSubject(int id)
        {
            try
            {
                var singleCourse = _subjectRepo.SelectById(id);
                return Ok(singleCourse);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult UpdateSubject(UpdateSubjectDTO updateSubjectDTO)
        {
            try
            {
                var objCourse = _context.Subjects.SingleOrDefault(opt => opt.SubjectId == updateSubjectDTO.SubjectId);
                objCourse.CourseId = updateSubjectDTO.CourseId;
                objCourse.SubCourseId = updateSubjectDTO.SubCourseId;
                objCourse.SubjectName = updateSubjectDTO.SubjectName;
                objCourse.SubjectDetails = updateSubjectDTO.SubjectDetails;
                objCourse.SubjectImage= updateSubjectDTO.SubjectImage;

                objCourse.UpdatedBy = updateSubjectDTO.UpdatedBy;
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
        public ActionResult DeleteSubject(int Id, int DeletedBy)
        {
            try
            {
                var objCourse = _context.Subjects.SingleOrDefault(opt => opt.SubjectId == Id);
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

        [HttpGet("{SubCourseId}")]
        public ActionResult GetSingleSubjectlistbySubcourseid(int SubCourseId)
        {
            try
            {
                var list = (from u in _context.Subjects
                            join b in _context.Courses on u.CourseId equals b.CourseId
                            join a in _context.SubCourses on u.SubCourseId equals a.SubCourseId
                            select new
                            {
                                u.SubjectId,
                                u.CourseId,
                                b.CourseName,
                                u.SubCourseId,
                                a.SubCourseName,
                                u.SubjectName,
                                u.SubjectDetails,
                                u.SubjectImage,
                                a.SubCoursePrice,
                                a.DiscountAmount,
                                a.SalePrice,
                                u.CreatedOn,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.SubCourseId == SubCourseId)
                            .OrderByDescending(x => x.SubjectId)
                            .ToList();

                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsNotified = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{SubCourseId}")]
        public ActionResult GetSubjectListbySubCourseId(int SubCourseId)
        {
            try
            {
                var list = (from u in _context.Subjects
                            join a in _context.SubCourses on u.SubCourseId equals a.SubCourseId

                            select new
                            {
                                u.SubjectId,
                                u.SubjectName,
                                u.SubCourseId,
                                a.SubCourseName,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.SubCourseId == SubCourseId).Distinct().ToList();

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
