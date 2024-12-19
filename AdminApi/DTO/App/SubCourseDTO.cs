using System;

namespace AdminApi.DTO.App
{
    public class SubCourseDTO
    {
        public int CourseId { get; set; }
        public string SubCourseName { get; set; }
        public string SubCourseDetails { get; set; }
        public int SubCourseDuration { get; set; }
        public string SubCourseImage { get; set; }
        public double SubCoursePrice { get; set; }
        public double DiscountAmount { get; set; }
        public double SalePrice { get; set; }
        public string Video { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class UpdateSubCourseDTO
    {
        public int SubCourseId { get; set; }
        public int CourseId { get; set; }
        public string SubCourseName { get; set; }
        public string SubCourseDetails { get; set; }
        public int SubCourseDuration { get; set; }
        //public string SubCourseImage { get; set; }
        public double SubCoursePrice { get; set; }
        public double DiscountAmount { get; set; }
        public double SalePrice { get; set; }
        public string Video { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
