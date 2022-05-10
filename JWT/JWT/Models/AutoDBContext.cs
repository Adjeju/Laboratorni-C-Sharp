using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace JWT.Models
{
    public partial class AutoDBContext : DbContext
    {
        public AutoDBContext()
        {
        }

        public AutoDBContext(DbContextOptions<AutoDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Auto> Auto { get; set; }
        public virtual DbSet<Files> Files { get; set; }
        public virtual DbSet<RefreshToken> RefreshToken { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-AMKUDO4;Initial Catalog=AutoDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auto>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.Mark).HasMaxLength(50);
            });

            modelBuilder.Entity<Files>(entity =>
            {
                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.UploadDate)
                    .HasColumnName("Upload_date")
                    .HasColumnType("date");

                entity.Property(e => e.Url).HasColumnName("url");
            });

            modelBuilder.Entity<RefreshToken>(entity =>
            {
                entity.Property(e => e.ExpiryDate)
                    .HasColumnName("Expiry_date")
                    .HasColumnType("date");

                entity.Property(e => e.Token).IsRequired();

                entity.Property(e => e.UserId).HasColumnName("User_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RefreshToken)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_RefreshToken_User");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Login).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Roles).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
