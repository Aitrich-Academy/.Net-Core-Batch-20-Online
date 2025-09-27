using SampleAPI.Models;
using Microsoft.EntityFrameworkCore;
using Domain.Models;
using Microsoft.AspNetCore.Builder;

namespace SampleAPI.Models
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }



        public virtual DbSet<CompanyUser> CompanyUsers { get; set; }



        public virtual DbSet<JobPost> JobPosts { get; set; }

        public virtual DbSet<JobProviderCompany> JobProviderCompanies { get; set; }

        public virtual DbSet<JobResponsibility> JobResponsibilities { get; set; }

        public virtual DbSet<JobSeeker> JobSeekers { get; set; }

        public virtual DbSet<SavedJob> SavedJobs { get; set; }
        public virtual DbSet<Location> Locations { get; set; }

        public virtual DbSet<Industry> Industries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<JobProviderCompany>(entity =>
        {
            entity.ToTable("JobProviderCompany");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            entity.Property(e => e.LegalName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            entity.Property(e => e.Summary)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            entity.Property(e => e.Website)
                    .HasMaxLength(50)
                    .IsUnicode(false);

            entity.HasOne(d => d.LocationNavigation)
                .WithMany(p => p.JobProviderCompanies)
                .HasForeignKey(d => d.Location)
                .OnDelete(DeleteBehavior.Restrict)    
                .HasConstraintName("FK_JobProviderCompany_Location");



            entity.HasOne(d => d.Industry)
               .WithMany()
               .HasForeignKey(d => d.IndustryId)
               .OnDelete(DeleteBehavior.Restrict)   // 🚀 fix here
               .HasConstraintName("FK_JobProviderCompany_Industry");




        });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Location");

                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.Discription)
                    .HasMaxLength(10)
                    .IsFixedLength();
                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });


            modelBuilder.Entity<Industry>(entity =>
            {
                entity.ToTable("Industry");

                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.Description)
                    .HasMaxLength(10)
                    .IsFixedLength();
                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<JobCategory>(entity =>
            {
                entity

                    .ToTable("JobCategory");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
