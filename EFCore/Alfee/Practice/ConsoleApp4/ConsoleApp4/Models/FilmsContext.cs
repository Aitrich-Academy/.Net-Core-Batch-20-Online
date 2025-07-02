using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp4.Models;

public partial class FilmsContext : DbContext
{
    public FilmsContext()
    {
    }

    public FilmsContext(DbContextOptions<FilmsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<English> Englishes { get; set; }

    public virtual DbSet<Hindi> Hindis { get; set; }

    public virtual DbSet<Malayalam> Malayalams { get; set; }

    public virtual DbSet<Tamil> Tamils { get; set; }

    public virtual DbSet<Telugu> Telugus { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-DBMHTCV2;Initial Catalog=Films;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<English>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__English__3214EC07C378F49F");

            entity.ToTable("English");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Actor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("actor");
            entity.Property(e => e.Actress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("actress");
            entity.Property(e => e.Director)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("director");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Hindi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Hindi__3214EC07EA59F790");

            entity.ToTable("Hindi");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Actor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("actor");
            entity.Property(e => e.Actress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("actress");
            entity.Property(e => e.Director)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("director");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Malayalam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Malayala__3214EC07171989C2");

            entity.ToTable("Malayalam");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Actor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("actor");
            entity.Property(e => e.Actress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("actress");
            entity.Property(e => e.Director)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("director");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Tamil>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tamil__3214EC072FEE0F99");

            entity.ToTable("Tamil");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Actor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("actor");
            entity.Property(e => e.Actress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("actress");
            entity.Property(e => e.Director)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("director");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Telugu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Telugu__3214EC07B0A72612");

            entity.ToTable("Telugu");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Actor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("actor");
            entity.Property(e => e.Actress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("actress");
            entity.Property(e => e.Director)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("director");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
