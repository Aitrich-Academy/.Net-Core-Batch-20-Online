using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.JobSeeker.DTO
{
    public class ViewappliedDto
    {
        public Guid Id { get; set; }
        public DateTime DateSaved { get; set; }
        public string Status { get; set; }

        public Guid JobId { get; set; }
        public string JobTitle { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string Industry { get; set; }
        public string Category { get; set; }
    }
}
