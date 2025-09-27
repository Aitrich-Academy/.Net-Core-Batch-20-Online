namespace HireMeNow_WebApi.API.Admin.RequestObjects
{
    public class SkillRequest
    {

        public Guid Id { get; set; }
        public string? Name { get; set; } //= null!;

        public string? Description { get; set; }//= null!;
    }
}
