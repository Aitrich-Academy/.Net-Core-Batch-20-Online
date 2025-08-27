namespace JobPortalAPI.DTOs
{
    public class UserDTO
    {
        public int UserId { get; set; }   // 👈 Add this
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
