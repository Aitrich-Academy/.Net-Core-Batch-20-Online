using Microsoft.EntityFrameworkCore;

namespace CustomerFeedbackApp.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Data Source=LAPTOP-DBMHTCV2;Initial Catalog=CustomerFeedbackApp;Integrated Security=True;Trust Server Certificate=True;");
        //    }
        //}

        public DbSet<Feedback> Feedbacks { get; set; }
    }
}
