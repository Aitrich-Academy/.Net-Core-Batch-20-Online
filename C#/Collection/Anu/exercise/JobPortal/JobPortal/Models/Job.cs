using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobPortal.Enums;

namespace JobPortal.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ProviderUsername { get; set; }
        public JobStatus Status { get; set; } = JobStatus.Open;
    }
}
