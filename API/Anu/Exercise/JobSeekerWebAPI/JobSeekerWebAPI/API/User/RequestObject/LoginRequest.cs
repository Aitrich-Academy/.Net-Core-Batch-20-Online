using System.ComponentModel.DataAnnotations;

namespace JobSeekerWebAPI.API.User.RequestObject
{
    public class LoginRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
