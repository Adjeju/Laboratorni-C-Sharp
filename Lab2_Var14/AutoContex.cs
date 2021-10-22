using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lab2_Var14
{
    public partial class AutoContex : DbContext
    {
        public AutoContex()
            : base("name=AutoContex")
        {
        }

        public virtual DbSet<Auto> Auto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auto>()
                .Property(e => e.Mark)
                .IsFixedLength();

            modelBuilder.Entity<Auto>()
                .Property(e => e.Year)
                .IsFixedLength();
        }
    }
}
