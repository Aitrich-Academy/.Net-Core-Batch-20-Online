using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace workshopmvc.Models
{
    public class Job
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid? Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Location { get; set; }

        public string? Experience { get; set; }

        public string? TypeOfWorkPlace { get; set; }

        public string? Salary { get; set; }

        public string? Responsibilities { get; set; }
        [ForeignKey(nameof(Company))]
        public Guid? CompanyId { get; set; }
       

        public string? JobType { get; set; }
        public virtual Company? Company { get; set; }

        public virtual User? CreatedUser { get; set; }





    }
}
