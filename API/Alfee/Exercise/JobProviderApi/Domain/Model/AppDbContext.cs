using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Domain.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public DbSet<JobProvider> JobProviders { get; set; }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Interview> Interviews { get; set; }
    }
}
