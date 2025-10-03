using Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JobSeekerWebAPI.API.Job.RequestObject
{
    public class AppliedJobRequest
    {
        //public Guid Id { get; set; }

        [Required]
        [ForeignKey(nameof(JobPost))]
        public Guid Job { get; set; }

        [Required]
        [ForeignKey(nameof(RegisterUser))]
        public Guid SavedBy { get; set; }

        public DateTime DateSaved  = DateTime.UtcNow;

        public string Status { get; set; } = "Applied";
    }
}
