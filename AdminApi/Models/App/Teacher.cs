using System;

namespace AdminApi.Models.App
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public int CourseId { get; set; }
        public int SubCourseId { get; set; }
        public int SubjectId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherDetails { get; set; }
        public string TeacherImage { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
