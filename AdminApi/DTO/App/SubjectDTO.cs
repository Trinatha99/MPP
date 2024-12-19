namespace AdminApi.DTO.App
{
    public class SubjectDTO
    {
        public int CourseId { get; set; }
        public int SubCourseId { get; set; }
        public string SubjectName { get; set; }
        public string SubjectDetails { get; set; }
        public string SubjectImage { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateSubjectDTO
    {
        public int SubjectId { get; set; }
        public int CourseId { get; set; }
        public int SubCourseId { get; set; }
        public string SubjectName { get; set; }
        public string SubjectDetails { get; set; }
        public string SubjectImage { get; set; }

        public int UpdatedBy { get; set; }
    }
}
