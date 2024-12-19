using System;
using System.Collections.Generic;

namespace AdminApi.DTO.App
{
    public class TeacherDTO
    {
        public int CourseId { get; set; }
        public int SubCourseId { get; set; }
        public int SubjectId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherDetails { get; set; }
        public string TeacherImage { get; set; }
        public int CreatedBy { get; set; }

       
    }
    public class UpdateTeacherDTO
    {
        public int TeacherId { get; set; }
        public int CourseId { get; set; }
        public int SubCourseId { get; set; }
        public int SubjectId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherDetails { get; set; }
        public string TeacherImage { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
