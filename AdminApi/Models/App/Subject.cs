using System;

namespace AdminApi.Models.App
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public int CourseId { get; set; }
        public int SubCourseId { get; set; }
        public string SubjectName { get; set; }
        public string SubjectDetails { get; set; }
        public string SubjectImage { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
