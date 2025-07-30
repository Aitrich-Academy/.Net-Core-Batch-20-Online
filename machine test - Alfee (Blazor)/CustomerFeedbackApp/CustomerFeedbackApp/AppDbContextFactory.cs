using CustomerFeedbackApp.Models;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace CustomerFeedbackApp
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            // Directly provide the connection string (bypass appsettings.json)
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-DBMHTCV2;Initial Catalog=CustomerFeedbackApp;Integrated Security=True;Trust Server Certificate=True;");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
