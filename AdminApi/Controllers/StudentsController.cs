using AdminApi.DTO.App;
using AdminApi.Models;
using AdminApi.Models.App;
using AdminApi.Models.Helper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class StudentsController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Students> _studentsRepo;

        private readonly IWebHostEnvironment _enviorment;
        public IConfiguration Configuration { get; }
        public StudentsController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Students> studentsRepo,
                                IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _studentsRepo = studentsRepo;
            _enviorment = enviorment;
            Configuration = configuration;
        }

        [HttpPost]
        public ActionResult CreateStudent(StudentsDTO studentsDTO)
        {
            var objCheck = _context.Studentss.SingleOrDefault(opt => opt.StudentsName == studentsDTO.StudentsName && opt.IsDeleted == false);
            try
            {
                if (objCheck == null)
                {

                    Students stu = new Students();
                    stu.StudentsName = studentsDTO.StudentsName;
                    stu.StudentsAssignment = studentsDTO.StudentsAssignment;
                    stu.CreatedBy = studentsDTO.CreatedBy;
                    stu.CreatedOn = DateTime.Now;
                    var obj = _studentsRepo.Insert(stu);
                    return Ok(obj);
                }
                else if (objCheck != null)
                {
                    return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Duplicate Student..!" });
                }
                return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet]
        public ActionResult GetStudentList()
        {
            try
            {
                var list = (from u in _context.Studentss

                            select new
                            {
                                u.StudentsId,
                                u.StudentsName,
                                u.StudentsAssignment,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false);



                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsGalleryCategorised = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public ActionResult GetSingleStudent(int id)
        {
            try
            {
                var GetSingleStudent = _studentsRepo.SelectById(id);
                return Ok(GetSingleStudent);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpPost]
        public ActionResult UpdateStudent(UpdateStudentsDTO updateStudentsDTO)
        {
            try
            {
                var objStudents = _context.Studentss.SingleOrDefault(opt => opt.StudentsId == updateStudentsDTO.StudentsId);

                objStudents.StudentsName = updateStudentsDTO.StudentsName;
                objStudents.StudentsAssignment = updateStudentsDTO.StudentsAssignment;
                objStudents.UpdatedBy = updateStudentsDTO.UpdatedBy;
                objStudents.UpdatedOn = System.DateTime.Now;


                _context.SaveChanges();
                return Ok(objStudents);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteStudent(int Id, int DeletedBy)
        {
            try
            {
                var objStudent = _context.Studentss.SingleOrDefault(opt => opt.StudentsId == Id);
                objStudent.IsDeleted = true;

                objStudent.UpdatedBy = DeletedBy;
                objStudent.UpdatedOn = System.DateTime.Now;


                _context.SaveChanges();
                return Ok(objStudent);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}
