using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Interview
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid ApplicantId { get; set; }
        public Guid JobProviderId { get; set; }
        public DateTime ScheduledDate { get; set; }
        public string Mode { get; set; } = null!; // e.g., Online, Offline
    }
}
