namespace AdminApi.DTO.App
{
    public class DemoVideoDTO
    {
        public int FacultyVideoUploadId { get; set; }
        public string DemoVideoName { get; set; }
        public string DemoVideoUrl { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateDemoVideoDTO
    {
        public int DemoVideoId { get; set; }
        public int FacultyVideoUploadId { get; set; }
        public string DemoVideoName { get; set; }
        public string DemoVideoUrl { get; set; }
        public int UpdatedBy { get; set; }
    }
}
