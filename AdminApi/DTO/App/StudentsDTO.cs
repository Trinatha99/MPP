using System;

namespace AdminApi.DTO.App
{
    public class StudentsDTO
    {
        public string StudentsName { get; set; }
        public string StudentsAssignment { get; set; }
        public int CreatedBy { get; set; }
    }

    public class UpdateStudentsDTO
    {
        public int StudentsId { get; set; }
        public string StudentsName { get; set; }
        public string StudentsAssignment { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
