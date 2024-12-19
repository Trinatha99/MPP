using System;

namespace AdminApi.Models.App
{
    public class Gallery
    {
        public int GalleryId { get; set; }  
        public string GalleryName { get; set; }
        public string GalleryCategoryImage { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }

    }
}
