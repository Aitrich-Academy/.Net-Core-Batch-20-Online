using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using workshopmvc.Enum;

namespace workshopmvc.Models
{
    public class User
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        public string? Gender { get; set; }

        public string? Location { get; set; }

        public string? Phone { get; set; }

        public string password { get; set; }
        public Roles? Role { get; set; }

        public string? About { get; set; }

        public string? Designation { get; set; }

        [ForeignKey(nameof(Company))]
        public Guid? CompanyId { get; set; } = null;

        public string? Status { get; set; }

        public byte[]? Image { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
