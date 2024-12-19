using System;

namespace AdminApi.Models.App
{
    public class DemoVideo
    {
        public int DemoVideoId { get; set; }
        public int FacultyVideoUploadId { get; set; }
        public string DemoVideoName { get; set; }
        public string DemoVideoUrl { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
