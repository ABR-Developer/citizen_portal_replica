using System.ComponentModel.DataAnnotations;
namespace Citizen_Portal.Models
{
    public class User
    {
        [Required(ErrorMessage ="Enter your name")]
        [StringLength(50, ErrorMessage = "Name should not be more than 50 charaters")]
        public string Name {    get;    set;    }

        [Required(ErrorMessage = "Enter your CNIC number")]
        [RegularExpression("[0-9]{5}[0-9]{6}[0-9]{1}")]
        public string CNIC {    get;    set;    }

        [Required(ErrorMessage = "Enter your E-mail address")]
        [EmailAddress]
        public string Email {    get;    set;    }
        [Required(ErrorMessage = "Enter your password")]

        public string Password {    get;    set;    }

        [Required(ErrorMessage = "Enter your mobile number")]
        [RegularExpression("[0-9]*")]
        [MinLength(5)]
        [MaxLength(12)]
        public string MobileNumber {    get;    set;    }

        [Required(ErrorMessage = "Enter your date of birth")]
        public string DOB {    get;    set;    }
        [Required(ErrorMessage = "Choose your gender")]
        public string Gender {    get;    set;    }
        [Required(ErrorMessage = "Choose your province")]
        public string Province {    get;    set;    }
        [Required(ErrorMessage = "Choose your province")]
        public string District {    get;    set;    }
        [Required(ErrorMessage = "Enter your area's postal code")]
        [StringLength(5, ErrorMessage = "Enter correct postal code")]
        public string postalCode {    get;    set;    }
        [Required(ErrorMessage = "Choose your Tehsil")]
        public string Tehsil {    get;    set;    }
        [Required(ErrorMessage = "Enter your current home address")]
        public string Address {    get;    set;    }
        //public string Status {    get;    set;    }
        public string Area_Code { get; set; }
        //public string User_Type {    get;    set;    }
        [Required(ErrorMessage = "Enter your telephone number")]
        public string TelephoneNumber {    get;    set;    }
    }
}