using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain.Extension
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
     : base(options)
        {
        }

        public virtual DbSet<RegisterUser> RegisterUsers { get; set; }

        public virtual DbSet<JobPost> JobPosts { get; set; }

        public virtual DbSet<Location> Locations { get; set; }

        public virtual DbSet<Industry> Industries { get; set; }

        public virtual DbSet<JobCategory> JobCategories { get; set; }

        public virtual DbSet<AppliedJobs> AppliedJobs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobPost>(entity =>
            {
                entity.ToTable("JobPost");

                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.JobSummary).HasMaxLength(50);
                entity.Property(e => e.JobTitle)
                    .HasMaxLength(10)
                    .IsFixedLength();
                entity.Property(e => e.PostedDate).HasColumnType("datetime");


                entity.HasOne(d => d.Location).WithMany(p => p.JobPosts)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobPost_Location");



                entity.HasOne(d => d.JobCategory)
            .WithMany()
            .HasForeignKey(d => d.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);


                entity.HasOne(d => d.Industry)
                      .WithMany()
                      .HasForeignKey(d => d.IndustryId)
                      .OnDelete(DeleteBehavior.Restrict);
            });



        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
