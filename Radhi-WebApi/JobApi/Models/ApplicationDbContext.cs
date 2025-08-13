using Microsoft.EntityFrameworkCore;

using JobApi.Model;

namespace JobApi.Models
{
    public class ApplicationDbContext:DbContext
    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
       public  DbSet<Job> Jobs { get; set; }
      public  DbSet<User> Users {  get; set; }


    }
}
