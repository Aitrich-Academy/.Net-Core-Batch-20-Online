using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Domain.Service.Profile.DTOs
{
    public partial class JobSeekerProfileDto
    {
        public Guid Id { get; set; }
        public Guid JobSeekerId { get; set; }
        public string? ProfileName { get; set; }
        public string? ProfileSummary { get; set; }

        // For Swagger uploads
        public IFormFile? SeekerImage { get; set; }
        public IFormFile? Resume { get; set; }

        // For Swagger responses
        public string? ImagePath { get; set; }  // will store wwwroot relative path like /Images/abc.jpg
        public string? ResumePath { get; set; }
    }
}
