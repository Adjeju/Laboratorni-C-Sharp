using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API.Models
{
    public partial class CarDBContext : DbContext
    {
        public CarDBContext()
        {
        }

        public CarDBContext(DbContextOptions<CarDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CarDb> CarDb { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=CarDB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarDb>(entity =>
            {
                entity.ToTable("CarDB");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.Mark).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
