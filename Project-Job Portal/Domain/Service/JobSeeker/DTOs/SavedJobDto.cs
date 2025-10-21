using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.JobSeeker.DTOs
{
    public class SavedJobDto
    {
        public Guid JobId { get; set; }
        public DateTime DateSaved { get; set; }

    }

}
