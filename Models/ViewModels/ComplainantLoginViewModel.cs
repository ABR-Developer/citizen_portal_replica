using System.ComponentModel.DataAnnotations;

namespace Citizen_Portal.Models.ViewModels
{
    public class ComplainantLoginViewModel
    {
        [Required(ErrorMessage = "Enter your CNIC number")]
        public string? nic_number { get; set; }
        
        [Required(ErrorMessage = "Enter your password")]
        public string? password { get; set; }
    }
}
