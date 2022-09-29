using Citizen_Portal.Models.Abstracts;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Citizen_Portal.Models
{
    public class Complainant : FullAuditModel
    {
        [Required(ErrorMessage ="Enter your name")]
        [StringLength(50, ErrorMessage = "Name should not be more than 50 charaters")]
        public string? name {    get;    set;    }

        [Required(ErrorMessage = "Enter your CNIC number")]
        //[RegularExpression(@"^[0-9]{5}-[0-9]{7}-[0-9]$", ErrorMessage = "Not a valid nic number")]
        public string? nic_number {    get;    set;    }

        [Required(ErrorMessage = "Enter your E-mail address")]
        [EmailAddress]
        public string? email {    get;    set;    }

        //[MinLength(8 , ErrorMessage ="Password must be greater that 8 characters")]
        [Required(ErrorMessage = "Enter your password")]
        public string? password {    get;    set;    }

        //[StringLength(13, MinimumLength = 10)]
        [Required(ErrorMessage = "Enter your mobile number")]
        //[RegularExpression(@"^([0-9]{10,13})$", ErrorMessage = "Not a valid number")]
        public string? mobile_number {    get;    set;    }

        [Required(ErrorMessage = "Enter your date of birth")]
        public DateTime? date_of_birth {    get;    set;    }

        [Required(ErrorMessage = "Choose your gender")]
        public string? gender {    get;    set;    }

        [Required(ErrorMessage = "Choose your province")]
        public string? province {    get;    set;    }

        [Required(ErrorMessage = "Choose your province")]
        public string? district {    get;    set;    }

        [Required(ErrorMessage = "Choose your Tehsil")]
        public string? tehsil {    get;    set;    }

        //[DisplayName("Permanent Home Address")]
        [Required(ErrorMessage = "Enter your permanent home address")]
        public string? permanent_address {    get;    set;    }

        //[DisplayName("Current Home Address")]
        [Required(ErrorMessage = "Enter your current home address")]
        public string? residential_address {    get;    set;    }

        //[DisplayName("Select Nationality")]
        [Required(ErrorMessage = "Select nationality")]
        public string? nationality { get; set; }

        //[DisplayName("Telephone/ landline number")]
        [Required(ErrorMessage = "Enter your telephone number")]
        public string? telephone_number {    get;    set;    }
        
        [Required(ErrorMessage = "Note: You must agree to the terms and conditions in order to continue")]
        [Range(typeof(bool), "true", "true")]
        public bool term_accepted {    get;    set;    }
        
        public string? profile_image {    get;    set;    }
  
        [StringLength(50 , ErrorMessage ="Length must be smaller than 50 characters")]
        public string? reason_abroad {    get;    set;    }

        public string? abroad_country {    get;    set;    }

        [StringLength(50, ErrorMessage = "Length must be smaller than 50 characters")]
        public string? reason_visit_pakistan {    get;    set;    }
    }
}