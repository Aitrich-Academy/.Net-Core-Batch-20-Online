using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Interviews.Dto
{
    public class InterviewDto
    {
        public Guid Id { get; set; }
        public Guid ApplicantId { get; set; }
        public DateTime ScheduledDate { get; set; }
        public string Mode { get; set; } = null!;
        public Guid JobProviderId { get; set; }
    }
}
