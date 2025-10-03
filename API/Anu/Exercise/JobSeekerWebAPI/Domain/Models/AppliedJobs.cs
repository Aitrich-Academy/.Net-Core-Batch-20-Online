using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public partial  class AppliedJobs
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [ForeignKey(nameof(JobPost))]
        public Guid Job { get; set; }

        [Required]
        [ForeignKey(nameof(RegisterUser))]
        public Guid SavedBy { get; set; }

        public DateTime DateSaved { get; set; }

        public string Status { get; set; } = "Applied";

        public virtual JobPost JobPost { get; set; }
        public virtual RegisterUser RegisterUser { get; set; }
    }
}
