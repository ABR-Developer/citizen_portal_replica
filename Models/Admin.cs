using System.ComponentModel.DataAnnotations;

namespace Citizen_Portal.Models
{
    public class Admin : IIdentityModel
    {

        [Required(ErrorMessage="Please Enter Name")]
        public String? name { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        public String? password { get; set; }
        public int Id { get; set; }
    }
}
