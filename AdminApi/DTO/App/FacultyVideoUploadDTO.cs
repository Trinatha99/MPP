using System.Collections.Generic;

namespace AdminApi.DTO.App
{
    public class FacultyVideoUploadDTO
    {
        public int CourseId { get; set; }
        public int SubCourseId { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }
        public int CreatedBy { get; set; }

        public List<DemoVideoDTO> DemoVideoDTOs { get; set; }
        public List<FixVideoDTO> FixVideoDTOs { get; set; }
    }
    public class UploadFacultyVideoUploadDTOP
    {
        public int FacultyVideoUploadId { get; set; }
        public int CourseId { get; set; }
        public int SubCourseId { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }
        public int? UpdatedBy { get; set; }
        public List<UpdateDemoVideoDTO> UpdateDemoVideoDTOs { get; set; }
        public List<UpdateFixVideoDTO> UpdateFixVideoDTOs { get; set; }
    }
}
