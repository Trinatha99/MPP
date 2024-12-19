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
    public class GalleryCategoryController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<GalleryCategory> _gallerycategoryRepo;

        private readonly IWebHostEnvironment _enviorment;
        public IConfiguration Configuration { get; }
        public GalleryCategoryController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<GalleryCategory> gallerycategoryRepo,
                                IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _gallerycategoryRepo = gallerycategoryRepo;
            _enviorment = enviorment;
            Configuration = configuration;
        }

        [HttpPost]
        public ActionResult CreateGalleryCategory(GalleryCategoryDTO galleryCategoryDTO)
        {
            var objCheck = _context.GalleryCategories.SingleOrDefault(opt => opt.GalleryCategoryName == galleryCategoryDTO.GalleryCategoryName && opt.IsDeleted == false);
            try
            {
                if (objCheck == null)
                {

                    GalleryCategory gal = new GalleryCategory();
                    gal.GalleryCategoryName = galleryCategoryDTO.GalleryCategoryName;
                    gal.CreatedBy = galleryCategoryDTO.CreatedBy;
                    var obj = _gallerycategoryRepo.Insert(gal);
                    return Ok(obj);
                }
                else if (objCheck != null)
                {
                    return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Duplicate GalleryCategory..!" });
                }
                return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetGalleryCategoryList()
        {
            try
            {
                var list = (from u in _context.GalleryCategories

                            select new { u.GalleryCategoryId, u.GalleryCategoryName, u.IsDeleted }).Where(x => x.IsDeleted == false);



                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsGalleryCategorised = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public ActionResult GetSingleGalleryCategory(int id)
        {
            try
            {
                var GetSingleGalleryCategory = _gallerycategoryRepo.SelectById(id);
                return Ok(GetSingleGalleryCategory);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult UpdateGalleryCategory(UpdateGalleryCategoryDTO updateGalleryCategoryDTO)
        {
            try
            {
                var objGalleryCategory = _context.GalleryCategories.SingleOrDefault(opt => opt.GalleryCategoryId == updateGalleryCategoryDTO.GalleryCategoryId);
                objGalleryCategory.GalleryCategoryName = updateGalleryCategoryDTO.GalleryCategoryName;

                objGalleryCategory.UpdatedBy = updateGalleryCategoryDTO.UpdatedBy;
                objGalleryCategory.UpdatedOn = System.DateTime.Now;


                _context.SaveChanges();
                return Ok(objGalleryCategory);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteGalleryCategory(int Id, int DeletedBy)
        {
            try
            {
                var objGalleryCategory = _context.GalleryCategories.SingleOrDefault(opt => opt.GalleryCategoryId == Id);
                objGalleryCategory.IsDeleted = true;

                objGalleryCategory.UpdatedBy = DeletedBy;
                objGalleryCategory.UpdatedOn = System.DateTime.Now;


                _context.SaveChanges();
                return Ok(objGalleryCategory);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}
