using Citizen_Portal.Models.Abstracts;
using System.ComponentModel.DataAnnotations;
namespace Citizen_Portal.Models
{
    public class Complainee : FullAuditModel
    {
        [Required(ErrorMessage = "Enter your name")]
        [StringLength(50, ErrorMessage = "Name should not be more than 50 charaters")]
        public string? name { get; set; }

        [Required(ErrorMessage = "Enter your landline number")]
        public string? office_landline_number { get; set; }

        [Required(ErrorMessage = "Enter your CNIC number")]
        public string? nic_number { get; set; }

        [Required(ErrorMessage = "Choose your gender")]
        public string? gender { get; set; }

        [Required(ErrorMessage = "Enter your E-mail address")]
        [EmailAddress]
        public string? email { get; set; }

        [Required(ErrorMessage = "Enter your password")]
        public string? password { get; set; }

        [Required(ErrorMessage = "Choose your province")]
        public string? province { get; set; }
        
        [Required(ErrorMessage = "Choose your district")]
        public string? district { get; set; }
        
        [Required(ErrorMessage = "Choose your tehsil")]
        public string? tehsil { get; set; }

        [Required(ErrorMessage = "Enter your office address")]
        public string? office_address { get; set; }

        [Required(ErrorMessage = "Choose Field")]
        public string? working_field { get; set; }

        public string? profile_image { get; set; }

        [Required(ErrorMessage = "Note: You must agree to the terms and conditions in order to continue")]
        [Range(typeof(bool), "true", "true")]
        public bool term_accepted { get; set; }
    }
}