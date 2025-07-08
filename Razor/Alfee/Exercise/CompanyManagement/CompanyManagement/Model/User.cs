using System.ComponentModel.DataAnnotations;

namespace CompanyManagement.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<CompanyMember> CompanyMembers { get; set; }
    }
}
