using System.ComponentModel.DataAnnotations;
using System;
using Domain.Models;
using Domain.Enums;

namespace HireMeNow_API_Admin.API.Admin.RequestObjects
{
    public class CompanyUserRequest
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        [Required]
        public Domain.Enums.Role Role { get; set; }
        public string? UserName { get; set; }
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;

        public Guid? Company { get; set; }

    }
}
