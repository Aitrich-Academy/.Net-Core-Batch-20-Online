using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.JobSeeker.DTO
{
    public class SeekerDto
    {
        public Guid Id { get; set; }
        public string? UserName { get; set; }

        public string? Password { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Phone { get; set; }

        public Domain.Enums.Role? Role { get; set; }

    }
}
