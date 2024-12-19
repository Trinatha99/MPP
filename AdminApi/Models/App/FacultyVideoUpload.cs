using System;

namespace AdminApi.Models.App
{
    public class FacultyVideoUpload
    {
        public int FacultyVideoUploadId { get; set; }
        public int CourseId { get; set; }
        public int SubCourseId { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
