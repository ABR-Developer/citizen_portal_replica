using Citizen_Portal.Models.Abstracts;
using System.ComponentModel.DataAnnotations;

namespace Citizen_Portal.Models
{
    public class Complaint : FullAuditModel
    {
        [Required(ErrorMessage = "Please select field")]
        public string? field { get; set; }

        public string? reason { get; set; }
        
        public string? complaint_type { get; set; }

        public string? title { get; set; }
        
        [Required(ErrorMessage = "Please Enter discription")]
        [StringLength(1000, ErrorMessage = "Name should not be more than 1000 charaters")]
        public string? discription { get; set; }

        public bool? hide_indentity { get; set; }

        [Required(ErrorMessage = "Please Enter Complete address")]
        public string? address { get; set; }

        //public List<string>? attachments_path { get; set; }
    }
}
