namespace HireMeNow_API_Admin.API.Admin.RequestObjects
{
    public class JobSeekerRequest
    {
        public Guid Id { get; set; }

        public string? UserName { get; set; }

        public string? FirstName { get; set; } //= null!;

        public string? LastName { get; set; }

        public string? Phone { get; set; }// = null!;

        public string? Email { get; set; }// = null!;
 
    }
}
