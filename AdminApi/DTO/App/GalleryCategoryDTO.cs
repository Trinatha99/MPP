using System;

namespace AdminApi.DTO.App
{
    public class GalleryCategoryDTO
    {
        public string GalleryCategoryName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class UpdateGalleryCategoryDTO
    {
        public int GalleryCategoryId { get; set; }
        public string GalleryCategoryName { get; set; }
        public int? UpdatedBy { get; set; }
    }

}
