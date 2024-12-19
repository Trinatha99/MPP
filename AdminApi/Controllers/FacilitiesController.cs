using AdminApi.Models.App;
using AdminApi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.DTO.App;
using AdminApi.Models.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using AdminApi.DTO;
using System.Linq;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class FacilitiesController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Facilities> _facilitiesRepo;
        private readonly IWebHostEnvironment _enviorment;
        public IConfiguration Configuration { get; }
        public FacilitiesController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Facilities> facilitiesRepo,
                                IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _facilitiesRepo = facilitiesRepo;
        }
        [HttpPost]
        public ActionResult CreateFacilities(FacilitiesDTO facilitiesDTO)
        {
            var objCheck = _context.GetFacilities.SingleOrDefault(opt => opt.FacilitiesName == facilitiesDTO.FacilitiesName && opt.IsDeleted == false);
            try
            {
                if (objCheck == null)
                {

                    Facilities facility = new Facilities();
                    facility.FacilitiesName = facilitiesDTO.FacilitiesName;
                    facility.FacilitiesDetails = facilitiesDTO.FacilitiesDetails;
                    facility.FacilitiesImage = facilitiesDTO.FacilitiesImage;
                    facility.FacilitiesVideo= facilitiesDTO.FacilitiesVideo;
                    facility.CreatedBy = facilitiesDTO.CreatedBy;
                    var obj = _facilitiesRepo.Insert(facility);
                    return Ok(obj);
                }
                else if (objCheck != null)
                {
                    return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Duplicate facilities..!" });
                }
                return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet]
        public ActionResult GetFacilitiesList()
        {
            try
            {
                var list = (from u in _context.GetFacilities

                            select new { u.FacilitiesId, u.FacilitiesName, u.FacilitiesDetails, u.FacilitiesImage, u.FacilitiesVideo, u.IsDeleted }).Where(x => x.IsDeleted == false);



                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFacility = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{id}")]
        public ActionResult GetSingleFacilities(int id)
        {
            try
            {
                var singleFacilities = _facilitiesRepo.SelectById(id);
                return Ok(singleFacilities);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpPost]
        public ActionResult UpdateFacilities(UpdateFacilitiesDTO UpdateFacilitiesDTO)
        {
            try
            {
                var objFacilities = _context.GetFacilities.SingleOrDefault(opt => opt.FacilitiesId == UpdateFacilitiesDTO.FacilitiesId);
                objFacilities.FacilitiesName = UpdateFacilitiesDTO.FacilitiesName;
                objFacilities.FacilitiesDetails = UpdateFacilitiesDTO.FacilitiesDetails;
                objFacilities.FacilitiesImage = UpdateFacilitiesDTO.FacilitiesImage;
                objFacilities.FacilitiesVideo= UpdateFacilitiesDTO.FacilitiesVideo;
                objFacilities.UpdatedBy = UpdateFacilitiesDTO.UpdatedBy;
                objFacilities.UpdatedOn = System.DateTime.Now;


                _context.SaveChanges();
                return Ok(objFacilities);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteFacilities(int Id, int DeletedBy)
        {
            try
            {
                var objFacilities = _context.GetFacilities.SingleOrDefault(opt => opt.FacilitiesId == Id);
                objFacilities.IsDeleted = true;

                objFacilities.UpdatedBy = DeletedBy;
                objFacilities.UpdatedOn = System.DateTime.Now;


                _context.SaveChanges();
                return Ok(objFacilities);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
   
}
