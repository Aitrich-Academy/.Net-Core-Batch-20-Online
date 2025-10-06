using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Applicant
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;

        public Guid JobProviderId { get; set; } // the provider this applicant applied to
    }
}
