using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Domain.Models
{
    public class JobApplication
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [ForeignKey(nameof(JobPost))]
        public Guid JobPostId { get; set; }
        public virtual JobPost JobPost { get; set; }

        [ForeignKey(nameof(Seeker))]
        public Guid ApplicantId { get; set; }
        public virtual JobSeeker Seeker { get; set; }

        [ForeignKey(nameof(Resume))]
        public Guid? ResumeId { get; set; }
        public virtual Resume? Resume { get; set; }

        public string? CoverLetter { get; set; }
        public DateTime DateSubmitted { get; set; }
        public Status Status { get; set; }
    }
}