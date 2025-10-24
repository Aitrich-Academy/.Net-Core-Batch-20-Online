using System.ComponentModel.DataAnnotations;

namespace Job_Portal.API.JobSeeker.RequestObjects
{
    public class ApplyJobRequest
    {
        [Required]
        public Guid JobPost_Id { get; set; }

    }
}
