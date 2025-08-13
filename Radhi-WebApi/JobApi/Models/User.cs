using System.ComponentModel.DataAnnotations;
using JobApi.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobApi.Model
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }  // PK

        [Required]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        public ICollection<Job> Jobs { get; set; }
    }
}
