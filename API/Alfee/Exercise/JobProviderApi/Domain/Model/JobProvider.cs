using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enum;

namespace Domain.Model
{
    public class JobProvider
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public UserRole Role { get; set; } = UserRole.JobProvider; 
    }
}
