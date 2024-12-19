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
    public class FacultyVideoUploadController : Controller 
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<FacultyVideoUpload> _facultyVideoUploadRepo;
        private readonly ISqlRepository<FixVideo> _FixVideoRepo;
        private readonly ISqlRepository<DemoVideo> _DemoVideoRepo;
        private readonly IWebHostEnvironment _enviorment;

        public FacultyVideoUploadController(IConfiguration config,
                             AppDbContext context,
                             ISqlRepository<FacultyVideoUpload> facultyVideoUploadRepo,
                             ISqlRepository<FixVideo> fixVideoRepo,
                             ISqlRepository<DemoVideo> demoVideoRepo,
                             IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _facultyVideoUploadRepo = facultyVideoUploadRepo;
            _FixVideoRepo = fixVideoRepo;
            _DemoVideoRepo = demoVideoRepo;
        }

        [HttpPost]


        public ActionResult CreateFacultyVideoUpload(FacultyVideoUploadDTO facultyVideoUploadDTO)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                FacultyVideoUpload facultyVideoUpload = new FacultyVideoUpload
                {
                    CourseId = facultyVideoUploadDTO.CourseId,
                    SubCourseId = facultyVideoUploadDTO.SubCourseId,
                    SubjectId = facultyVideoUploadDTO.SubjectId,
                    TeacherId = facultyVideoUploadDTO.TeacherId,
                    CreatedBy = facultyVideoUploadDTO.CreatedBy,
                    CreatedOn = DateTime.Now
                };

                var createdFacultyVideoUpload = _facultyVideoUploadRepo.Insert(facultyVideoUpload);

                if (facultyVideoUploadDTO.FixVideoDTOs != null)
                {
                    foreach (var fixVideoDTO in facultyVideoUploadDTO.FixVideoDTOs)
                    {
                        FixVideo fixVideo = new FixVideo
                        {
                            FacultyVideoUploadId = createdFacultyVideoUpload.FacultyVideoUploadId,
                            FixVideoName = fixVideoDTO.FixVideoName,
                            FixVideoUrl = fixVideoDTO.FixVideoUrl,
                            CreatedBy = fixVideoDTO.CreatedBy,
                            CreatedOn = DateTime.Now
                        };
                        _FixVideoRepo.Insert(fixVideo);
                    }
                }

                if (facultyVideoUploadDTO.DemoVideoDTOs != null)
                {
                    foreach (var demoVideoDTO in facultyVideoUploadDTO.DemoVideoDTOs)
                    {
                        DemoVideo demoVideo = new DemoVideo
                        {
                            FacultyVideoUploadId = createdFacultyVideoUpload.FacultyVideoUploadId,
                            DemoVideoName = demoVideoDTO.DemoVideoName,
                            DemoVideoUrl = demoVideoDTO.DemoVideoUrl,
                            CreatedBy = demoVideoDTO.CreatedBy,
                            CreatedOn = DateTime.Now
                        };
                        _DemoVideoRepo.Insert(demoVideo);
                    }
                }

                transaction.Commit();
                return Ok(createdFacultyVideoUpload);
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }


        }


        [HttpGet]
        public ActionResult GetFacultyVideoUploadList()
        {
            try
            {
                var list = (from u in _context.FacultyVideoUploads
                            join a in _context.Courses on u.CourseId equals a.CourseId
                            join b in _context.SubCourses on u.SubCourseId equals b.SubCourseId
                            join c in _context.Subjects on u.SubjectId equals c.SubjectId
                            join d in _context.Teachers on u.TeacherId equals d.TeacherId

                            where !u.IsDeleted
                            select new
                            {
                                u.FacultyVideoUploadId,
                                u.CourseId,
                                a.CourseName,
                                u.SubCourseId,
                                b.SubCourseName,
                                u.SubjectId,
                                c.SubjectName,
                                u.TeacherId,
                                d.TeacherName,
                                d.TeacherImage,
                                u.IsDeleted,
                                FixVideos = (from fv in _context.FixVideos
                                             where fv.FacultyVideoUploadId == u.FacultyVideoUploadId && !fv.IsDeleted
                                             select new
                                             {
                                                 fv.FixVideoId,
                                                 fv.FixVideoName,
                                                 fv.FixVideoUrl,
                                                 fv.CreatedBy
                                             }).ToList(),
                                DemoVideos = (from dv in _context.DemoVideos
                                              where dv.FacultyVideoUploadId == u.FacultyVideoUploadId && !dv.IsDeleted
                                              select new
                                              {
                                                  dv.DemoVideoId,
                                                  dv.DemoVideoName,
                                                  dv.DemoVideoUrl,
                                                  dv.CreatedBy
                                              }).ToList()
                            }).ToList();

                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsCoursed = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetFacultyVideoUploadListt()
        {
            try
            {
                var list = (from u in _context.FacultyVideoUploads
                            join a in _context.Courses on u.CourseId equals a.CourseId
                            join b in _context.SubCourses on u.SubCourseId equals b.SubCourseId
                            join c in _context.Subjects on u.SubjectId equals c.SubjectId
                            join d in _context.Teachers on u.TeacherId equals d.TeacherId
                            join fv in _context.FixVideos on u.FacultyVideoUploadId equals fv.FacultyVideoUploadId into fixVideoGroup
                            from fixVideo in fixVideoGroup.DefaultIfEmpty()
                            join dv in _context.DemoVideos on u.FacultyVideoUploadId equals dv.FacultyVideoUploadId into demoVideoGroup
                            from demoVideo in demoVideoGroup.DefaultIfEmpty()
                            where u.IsDeleted == false
                            select new
                            {
                                u.CourseId,
                                a.CourseName,
                                u.SubCourseId,
                                b.SubCourseName,
                                u.SubjectId,
                                c.SubjectName,
                                u.TeacherId,
                                d.TeacherName,
                                fixVideo.FixVideoName,
                                fixVideo.FixVideoUrl,
                                demoVideo.DemoVideoName,
                                demoVideo.DemoVideoUrl,
                                u.IsDeleted
                            }).ToList();

                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpPost]
        public ActionResult UpdateFacultyVideoUpload(UploadFacultyVideoUploadDTOP uploadFacultyVideoUploadDTOP)
        {
            try
            {
                var objCourse = _context.FacultyVideoUploads.SingleOrDefault(opt => opt.FacultyVideoUploadId == uploadFacultyVideoUploadDTOP.FacultyVideoUploadId);
                objCourse.CourseId = uploadFacultyVideoUploadDTOP.SubCourseId;
                objCourse.SubCourseId = uploadFacultyVideoUploadDTOP.SubCourseId;
                objCourse.SubjectId = uploadFacultyVideoUploadDTOP.SubCourseId;
                objCourse.TeacherId = uploadFacultyVideoUploadDTOP.TeacherId;
                objCourse.UpdatedBy = uploadFacultyVideoUploadDTOP.UpdatedBy;
                objCourse.UpdatedOn = System.DateTime.Now;


                _context.SaveChanges();
                return Ok(objCourse);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public ActionResult GetSingleFacultyVideoUpload(int id)
        {
            try
            {
                var singleFacultyVideoUpload = _facultyVideoUploadRepo.SelectById(id);
                return Ok(singleFacultyVideoUpload);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteFacultyVideoUpload(int Id, int DeletedBy)
        {
            try
            {
                var objCourse = _context.FacultyVideoUploads.SingleOrDefault(opt => opt.FacultyVideoUploadId == Id);
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

        [HttpGet("{TeacherId}")]
        public ActionResult GetVideouploadListbyTeacherId(int TeacherId)
        {
            try
            {
                var list = (from u in _context.FacultyVideoUploads
                            join a in _context.Teachers on u.TeacherId equals a.TeacherId
                            where u.IsDeleted == false && u.TeacherId == TeacherId
                            select new
                            {
                                u.TeacherId,
                                a.TeacherName,
                                a.TeacherImage,
                                u.IsDeleted,
                                FixVideos = (from fv in _context.FixVideos
                                             where fv.FixVideoId == u.TeacherId
                                             select new { fv.FixVideoName, fv.FixVideoUrl }).ToList(),
                                DemoVideos = (from dv in _context.DemoVideos
                                              where dv.DemoVideoId == u.TeacherId
                                              select new { dv.DemoVideoName, dv.DemoVideoUrl }).ToList()
                            }).Distinct().ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }




        //[HttpGet("{TeacherId}")]
        //public ActionResult GetVideouploadListbyTeacherId(int TeacherId)
        //{
        //    try
        //    {
        //        var list = (from u in _context.FacultyVideoUploads
        //                    join a in _context.Teachers on u.TeacherId equals a.TeacherId


        //                    select new
        //                    {
        //                        u.TeacherId,
        //                        a.TeacherName,
        //                        a.TeacherImage,
        //                        u.IsDeleted
        //                    }).Where(x => x.IsDeleted == false && x.TeacherId == TeacherId).Distinct().ToList();

        //        int totalRecords = list.Count();

        //        return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
        //    }

        //    catch (Exception ex)
        //    {
        //        return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
        //    }
        //}


    }
}
