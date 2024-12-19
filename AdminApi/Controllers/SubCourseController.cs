using AdminApi.Models.App;
using AdminApi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.DTO.App;
using System.Linq;
using System;
using AdminApi.Models.Helper;
using Microsoft.EntityFrameworkCore;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class SubCourseController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<SubCourse> _subcourseRepo;
        private readonly IWebHostEnvironment _enviorment;
        public IConfiguration Configuration { get; }
        public SubCourseController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<SubCourse> subcourseRepo
                               )
        {
            _config = config;
            _context = context;
            _subcourseRepo = subcourseRepo;
        }

        //[HttpPost]
        //public ActionResult CreateSubCourse(SubCourseDTO subCourseDTO)
        //{
        //    var objCheck = _context.SubCourses.SingleOrDefault(opt => opt.SubCourseName == subCourseDTO.SubCourseName);
        //    try
        //    {
        //        if (objCheck == null)
        //        {
        //            SubCourse sub = new SubCourse();
        //            sub.CourseId= subCourseDTO.CourseId;
        //            sub.SubCourseName= subCourseDTO.SubCourseName;
        //            sub.SubCourseDetails= subCourseDTO.SubCourseDetails;
        //            sub.SubCourseDuration= subCourseDTO.SubCourseDuration;
        //            sub.SubCourseImage= subCourseDTO.SubCourseImage;
        //            sub.SubCoursePrice= subCourseDTO.SubCoursePrice;
        //            sub.DiscountAmount=subCourseDTO.DiscountAmount;
        //            sub.SalePrice=subCourseDTO.SalePrice;
        //            sub.CreatedBy= subCourseDTO.CreatedBy;
        //            sub.CreatedOn= DateTime.Now;
        //            var obj= _subcourseRepo.Insert(sub);
        //            return Ok(obj);
        //        }
        //        else if (objCheck !=null)
        //        {
        //            return Accepted(new Confirmation { Status = "Diplicate", ResponseMsg = "Duplicate SubCourse" });
        //        }
        //        return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something Unexpected" });
        //    }
        //    catch(Exception ex)
        //    { 
        //        return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message});
        //    }
        //}

        private string ExtractYouTubeVideoId(string url)
        {
            var regex = new System.Text.RegularExpressions.Regex(@"(?:https?:\/\/)?(?:www\.)?(?:youtube\.com\/(?:[^\/\n\s]+\/\S+\/|(?:v|e(?:mbed)?)\/|\S*?[?&]v=)|youtu\.be\/)([a-zA-Z0-9_-]{11})");
            var match = regex.Match(url);
            return match.Success ? match.Groups[1].Value : null;
        }
        [HttpPost]
        public ActionResult CreateSubCourse(SubCourseDTO subCourseDTO)
        {
            var objCheck = _context.SubCourses.SingleOrDefault(opt => opt.SubCourseName == subCourseDTO.SubCourseName);
            try
            {
                if (objCheck == null)
                {
                    SubCourse sub = new SubCourse
                    {
                        CourseId = subCourseDTO.CourseId,
                        SubCourseName = subCourseDTO.SubCourseName,
                        SubCourseDetails = subCourseDTO.SubCourseDetails,
                        SubCourseDuration = subCourseDTO.SubCourseDuration,
                        //SubCourseImage = subCourseDTO.SubCourseImage,
                        SubCoursePrice = subCourseDTO.SubCoursePrice,
                        DiscountAmount = subCourseDTO.DiscountAmount,
                        SalePrice = subCourseDTO.SalePrice,
                        CreatedBy = subCourseDTO.CreatedBy,
                        CreatedOn = DateTime.Now,
                        Video = ExtractYouTubeVideoId(subCourseDTO.Video) // Extract and set the video ID
                    };

                    var obj = _subcourseRepo.Insert(sub);
                    return Ok(obj);
                }
                else if (objCheck != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate SubCourse" });
                }
                return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something Unexpected" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet]
        public ActionResult GetSubCourseList()
        {
            try
            {
                var list = (from u in _context.SubCourses
                            join a in _context.Courses on u.CourseId equals a.CourseId
                            select new
                            { u.SubCourseId,
                                u.CourseId,
                                a.CourseName,
                                u.SubCourseName,
                                u.SubCourseDetails,
                                u.SubCourseDuration,
                               // u.SubCourseImage,
                                u.SubCoursePrice,
                                u.DiscountAmount,
                                u.SalePrice,
                                u.Video,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false);


                               int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsNotified = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public ActionResult GetSingleSubCourse(int id)
        {
            try
            {
                var singleSubCourse = _subcourseRepo.SelectById(id);
                return Ok(singleSubCourse);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{courseid}")]
        public ActionResult GetSingleSubCourselistbycourseid(int courseid)
        {
            try
            {
                var list = (from u in _context.SubCourses
                            join a in _context.Courses on u.CourseId equals a.CourseId
                            select new
                            {
                                u.SubCourseId,
                                u.CourseId,
                                a.CourseName,
                                u.SubCourseName,
                                u.SubCourseDetails,
                                u.SubCourseDuration,
                                //u.SubCourseImage,
                                u.Video,
                                u.SubCoursePrice,
                                u.DiscountAmount,
                                u.SalePrice,
                                u.CreatedOn,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.CourseId == courseid)
                            .OrderByDescending(x => x.SubCourseId)
                            .ToList();

                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsNotified = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpPost]
        public ActionResult UpdateSubCourse(UpdateSubCourseDTO updateSubCourseDTO)
        {
            try
            {
                var objSubCourse = _context.SubCourses.SingleOrDefault(opt => opt.SubCourseId == updateSubCourseDTO.SubCourseId);
                objSubCourse.CourseId = updateSubCourseDTO.CourseId;
                objSubCourse.SubCourseName = updateSubCourseDTO.SubCourseName;
                objSubCourse.SubCourseDetails= updateSubCourseDTO.SubCourseDetails;
                objSubCourse.SubCourseDuration = updateSubCourseDTO.SubCourseDuration;
                //objSubCourse.SubCourseImage = updateSubCourseDTO.SubCourseImage;
                objSubCourse.SubCoursePrice= updateSubCourseDTO.SubCoursePrice;
                objSubCourse.DiscountAmount=updateSubCourseDTO.DiscountAmount;
                objSubCourse.SalePrice=updateSubCourseDTO.SalePrice;
                objSubCourse.Video = updateSubCourseDTO.Video;
                objSubCourse.UpdatedBy = updateSubCourseDTO.UpdatedBy;
                objSubCourse.UpdatedOn = System.DateTime.Now;


                _context.SaveChanges();
                return Ok(objSubCourse);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteSubCourse(int Id, int DeletedBy)
        {
            try
            {
                var objSubCourse = _context.SubCourses.SingleOrDefault(opt => opt.SubCourseId == Id);
                objSubCourse.IsDeleted = true;

                objSubCourse.UpdatedBy = DeletedBy;
                objSubCourse.UpdatedOn = System.DateTime.Now;


                _context.SaveChanges();
                return Ok(objSubCourse);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

       
        [HttpGet("{CourseId}")]
        public ActionResult GetSubCourseListbyCourseId(int CourseId)
        {
            try
            {
                var list = (from u in _context.SubCourses
                            join a in _context.Courses on u.CourseId equals a.CourseId

                            select new
                            {
                                u.SubCourseId,
                                u.SubCourseName,
                                u.CourseId,
                                a.CourseName,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.CourseId == CourseId).Distinct().ToList();

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
