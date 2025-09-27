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
    public partial class DbHireMeNowWebApiContext : DbContext
    {
        public DbHireMeNowWebApiContext(DbContextOptions<DbHireMeNowWebApiContext> options)
       : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Data Source=ANOOD;Initial Catalog=HireMeNow_Api_Admin;Integrated Security=True;Trust Server Certificate=True",
                    b => b.MigrationsAssembly("HireMeNow_API_Admin"));  
            }
        }


        public virtual DbSet<AuthUser> AuthUsers { get; set; }
        public virtual DbSet<SystemUser> SystemUsers { get; set; }

        
       
        public virtual DbSet<JobSeeker> JobSeekers { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }

        public virtual DbSet<CompanyUser> CompanyUsers { get; set; }



        public virtual DbSet<JobPost> JobPosts { get; set; }

        public virtual DbSet<JobProviderCompany> JobProviderCompanies { get; set; }

        public virtual DbSet<JobResponsibility> JobResponsibilities { get; set; }

        

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
                   .HasConstraintName("FK_JobProviderCompany_Industry");




            });



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

                entity.HasOne(d => d.PostedByNavigation).WithMany(p => p.JobPosts)
                    .HasForeignKey(d => d.PostedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobPost_PostedBy");

          //      entity.HasOne(d => d.Company)
          //.WithMany(c => c.JobPosts)
          //.HasForeignKey(d => d.CompanyId)
          //.OnDelete(DeleteBehavior.Restrict) // 🔹 Use Restrict to avoid multiple cascade paths
          //.HasConstraintName("FK_JobPost_JobProviderCompany");

                entity.HasOne(d => d.JobCategory)
            .WithMany()
            .HasForeignKey(d => d.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Industry)
                      .WithMany()
                      .HasForeignKey(d => d.IndustryId)
                      .OnDelete(DeleteBehavior.Restrict);
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
