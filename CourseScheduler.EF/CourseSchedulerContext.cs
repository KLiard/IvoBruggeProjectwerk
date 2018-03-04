using CourseScheduler.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CourseScheduler.EF
{
    public class CourseSchedulerContext
        : DbContext
    {
        public DbSet<Module> Modules { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Module>()
                .Property(m => m.Code)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Module>()
                .Property(m => m.Naam)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Module>()
                .Property(m => m.Lestijden)
                .IsRequired();

            modelBuilder.Entity<Module>()
                .Property(m => m.Studierichting)
                .HasColumnType(nameof(DbType.Int32))
                .IsRequired();
        }
    }
}