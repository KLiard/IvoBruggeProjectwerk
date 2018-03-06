using CourseScheduler.Domain.Models;
using Microsoft.EntityFrameworkCore;
using CourseScheduler.EF.Configuration;

namespace CourseScheduler.EF
{
    public class CourseSchedulerContext
        : DbContext
    {
        public DbSet<Module> Modules { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ModuleConfiguration());
        }

        public virtual void Commit()
        {
            SaveChanges();
        }
    }
}