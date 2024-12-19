namespace AdminApi.DTO.App
{
    public class FixVideoDTO
    {
        public int FacultyVideoUploadId { get; set; }
        public string FixVideoName { get; set; }
        public string FixVideoUrl { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateFixVideoDTO
    {
        public int FixVideoId { get; set; }
        public int FacultyVideoUploadId { get; set; }
        public string FixVideoName { get; set; }
        public string FixVideoUrl { get; set; }
        public int UpdatedBy { get; set; }
    }
}
