using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Domain.Models;

public partial class CompanyUser
{
    public Guid Id { get; set; }
    public string? FirstName { get; set; }   // was non-nullable
    public string? LastName { get; set; }
    [Required]
    public Enums.Role Role { get; set; }
    public string? UserName { get; set; }
    public string? Email { get; set; }       // was non-nullable
    public string? Phone { get; set; }       // was non-nullable

    [ForeignKey(nameof(CompanyNavigation))]
    public Guid? Company { get; set; }
    [JsonIgnore]
    public virtual JobProviderCompany? CompanyNavigation { get; set; }

    public virtual ICollection<JobPost> JobPosts { get; set; } = new List<JobPost>();
}
