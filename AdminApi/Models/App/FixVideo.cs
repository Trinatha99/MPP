using System;

namespace AdminApi.Models.App
{
    public class FixVideo
    {
        public int FixVideoId { get; set; }
        public int FacultyVideoUploadId { get; set; }
        public string FixVideoName { get; set; }
        public string FixVideoUrl { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
