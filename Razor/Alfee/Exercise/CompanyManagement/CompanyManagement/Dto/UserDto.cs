using System.ComponentModel.DataAnnotations;

namespace CompanyManagement.Dto
{
    public class UserDto
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string? Email { get; set; }
    }
}
