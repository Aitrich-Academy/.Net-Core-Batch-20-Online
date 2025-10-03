using System.ComponentModel.DataAnnotations;
using System;
using Domain.Models;
using Domain.Enums;

namespace JobSeekerWebAPI.API.User.RequestObject
{
    public class RegisterRequest
    {
         
        public string? UserName { get; set; }

        public string? Password { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        public string? Phone { get; set; }

        public Domain.Enums.Role? Role { get; set; }
    }
}
