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
    public class GalleryController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Gallery> _galleryRepo;

        private readonly IWebHostEnvironment _enviorment;
        public IConfiguration Configuration { get; }
        public GalleryController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Gallery> galleryRepo,
                                IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _galleryRepo = galleryRepo;
            _enviorment = enviorment;
            Configuration = configuration;
        }

        [HttpPost]
        public ActionResult CreateGallery(GalleryDTO galleryDTO)
        {
            var objCheck = _context.Galleries.SingleOrDefault(opt => opt.GalleryName == galleryDTO.GalleryName && opt.IsDeleted == false);
            try
            {
                if (objCheck == null)
                {

                    Gallery gall = new Gallery();
                    gall.GalleryName = galleryDTO.GalleryName;
                    gall.GalleryCategoryImage = galleryDTO.GalleryCategoryImage;
                    gall.CreatedBy = galleryDTO.CreatedBy;
                    gall.CreatedOn = DateTime.Now;
                    var obj = _galleryRepo.Insert(gall);
                    return Ok(obj);
                }
                else if (objCheck != null)
                {
                    return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Duplicate Gallery..!" });
                }
                return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetGalleryList()
        {
            try
            {
                var list = (from u in _context.Galleries

                            select new { u.GalleryId,
                                u.GalleryName,
                                u.GalleryCategoryImage,
                                u.IsDeleted }).Where(x => x.IsDeleted == false);



                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsGalleryCategorised = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public ActionResult GetSingleGallery(int id)
        {
            try
            {
                var GetSingleGallery = _galleryRepo.SelectById(id);
                return Ok(GetSingleGallery);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

       

        [HttpPost]
        public ActionResult UpdateGallery(UpdateGalleryDTO updateGalleryDTO)
        {
            try
            {
                var objGallery = _context.Galleries.SingleOrDefault(opt => opt.GalleryId == updateGalleryDTO.GalleryId);
                
                objGallery.GalleryName = updateGalleryDTO.GalleryName;
                objGallery.GalleryCategoryImage= updateGalleryDTO.GalleryCategoryImage;
                objGallery.UpdatedBy = updateGalleryDTO.UpdatedBy;
                objGallery.UpdatedOn = System.DateTime.Now;


                _context.SaveChanges();
                return Ok(objGallery);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteGallery(int Id, int DeletedBy)
        {
            try
            {
                var objGallery = _context.Galleries.SingleOrDefault(opt => opt.GalleryId == Id);
                objGallery.IsDeleted = true;

                objGallery.UpdatedBy = DeletedBy;
                objGallery.UpdatedOn = System.DateTime.Now;


                _context.SaveChanges();
                return Ok(objGallery);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}
