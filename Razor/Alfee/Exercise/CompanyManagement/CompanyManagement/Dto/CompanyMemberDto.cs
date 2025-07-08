using System.ComponentModel.DataAnnotations;

namespace CompanyManagement.Dto
{
    public class CompanyMemberDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;  // required
        public string Position { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public string Department { get; set; } = string.Empty;
        public int? UserId { get; internal set; }
    }
}
