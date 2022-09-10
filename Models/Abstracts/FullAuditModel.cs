using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Citizen_Portal.Models.Abstracts
{
    public abstract class FullAuditModel
    {
        [Key]
        public int ID { get; set; }
        public bool IsActive { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? LastModifyDate { get; set; }
        public int? CreatedById { get; set; }
        public int? LastModifyById { get; set; }
    }
}
