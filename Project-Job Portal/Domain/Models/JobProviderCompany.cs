using System.ComponentModel.DataAnnotations.Schema;
using Domain.Models;
using Microsoft.AspNetCore.Http;

public partial class JobProviderCompany
{
    public Guid Id { get; set; }
    public string? LegalName { get; set; }    // was non-nullable
    public string? Email { get; set; }        // was non-nullable
    public string? Address { get; set; }      // was non-nullable
    public string? Summary { get; set; }      // was non-nullable
    public string? Website { get; set; }      // was non-nullable

    public Guid? Location { get; set; }
    public virtual Location? LocationNavigation { get; set; }

    public byte[]? ProfilePictureData { get; set; }

    [NotMapped]
    public IFormFile? ProfilePictureFile { get; set; }

    public virtual ICollection<JobPost> JobPosts { get; set; } = new List<JobPost>();
    public virtual ICollection<CompanyUser> CompanyUsers { get; set; } = new List<CompanyUser>();
}
