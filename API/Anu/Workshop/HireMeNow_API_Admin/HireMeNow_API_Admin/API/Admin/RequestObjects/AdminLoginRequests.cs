using System.ComponentModel.DataAnnotations;

namespace HireMeNow_API_Admin.API.Admin.RequestObjects
{
    public class AdminLoginRequests
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
