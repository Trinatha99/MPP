using System;

namespace AdminApi.Models.App
{
    public class Facilities
    {
        public int FacilitiesId { get; set; }
        public string FacilitiesName { get; set;}
        public string FacilitiesDetails { get;set;} 
        public string FacilitiesImage { get;set;}
        public string FacilitiesVideo {  get; set;}
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
