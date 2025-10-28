using Domain.Models;

public partial class Industry
{
    public Guid Id { get; set; }
    public string? Name { get; set; }          // was non-nullable
    public string? Description { get; set; }   // was non-nullable

    public virtual ICollection<JobPost> JobPosts { get; set; } = new List<JobPost>();
}
