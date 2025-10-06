using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Applicants.Dto
{
    public class ApplicantDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
