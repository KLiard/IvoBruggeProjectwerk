using Microsoft.EntityFrameworkCore;

namespace CourseScheduler.EF
{
    public class CourseSchedulerContext
        : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}