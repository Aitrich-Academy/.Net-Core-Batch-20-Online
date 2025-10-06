using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Profile.Dto
{
    public class JobProviderProfileDto
    {
        public Guid Id { get; set; }
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public string Role { get; set; } = null!;
    }
}
