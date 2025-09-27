using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Service.Admin.DTOs
{
    public class CompanyUserDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        [Required]
        public Enums.Role Role { get; set; }
        public string? UserName { get; set; }
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;

        public Guid? Company { get; set; }

    }
}
