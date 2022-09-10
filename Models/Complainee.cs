using Citizen_Portal.Models.Abstracts;
using System.ComponentModel.DataAnnotations;
namespace Citizen_Portal.Models
{
    public class Complainee : FullAuditModel
    {
        [Required(ErrorMessage = "Select courtry code")]
        public string? nationality { get; set; }

        [Required(ErrorMessage = "Enter your name")]
        [StringLength(50, ErrorMessage = "Name should not be more than 50 charaters")]
        public string? name { get; set; }

        [Required(ErrorMessage = "Enter your landline number")]
        public string? office_landline_number { get; set; }

        [Required(ErrorMessage = "Enter your CNIC number")]
        [RegularExpression("[0-9]{5}[0-9]{6}[0-9]{1}")]
        public string? cnic { get; set; }

        [Required(ErrorMessage = "Choose your gender")]
        public string? gender { get; set; }

        [Required(ErrorMessage = "Enter your E-mail address")]
        [EmailAddress]
        public string? email { get; set; }

        [Required(ErrorMessage = "Enter your password")]
        public string? password { get; set; }

        [Required(ErrorMessage = "Enter your confirm password")]
        public string? confirm_password { get; set; }

        [Required(ErrorMessage = "Choose your province")]
        public string? province { get; set; }

        [Required(ErrorMessage = "Enter your office address")]
        public string? office_address { get; set; }

        [Required(ErrorMessage = "Select courtry code")]
        public string? country_code { get; set; }
        
        [Required(ErrorMessage = "Choose Field")]
        public string? working_field { get; set; }

        [Required(ErrorMessage = "Enter your telephone number")]
        public bool term_accepted { get; set; }
    }
}