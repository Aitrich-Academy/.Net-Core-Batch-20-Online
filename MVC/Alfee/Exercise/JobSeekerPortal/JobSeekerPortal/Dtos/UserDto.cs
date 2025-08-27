using JobSeekerPortal.Enums;

namespace JobSeekerPortal.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public RoleType Role { get; set; }
        public GenderType Gender { get; set; }
    }
}
