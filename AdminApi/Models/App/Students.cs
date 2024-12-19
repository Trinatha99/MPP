using System;

namespace AdminApi.Models.App
{
    public class Students
    {
        public int StudentsId { get; set; }
        public string StudentsName { get; set; }
        public string StudentsAssignment { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
