using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Service.Job.DTO
{
    public class AppliedJobDto
    {
        public Guid Id { get; set; }

        [Required]
        [ForeignKey(nameof(JobPost))]
        public Guid Job { get; set; }

        [Required]
        [ForeignKey(nameof(RegisterUser))]
        public Guid SavedBy { get; set; }

        public DateTime DateSaved { get; set; }= DateTime.UtcNow;

        public string Status { get; set; } = "Applied";

    
    }
}
