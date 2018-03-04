using CourseScheduler.Core.UnitOfWork.Contracts;

namespace CourseScheduler.EF.UnitOfWork
{
    public class UnitOfWork
        : IUnitOfWork
    {
        public CourseSchedulerContext DbContext => new CourseSchedulerContext();

        public void Commit()
        {
            DbContext.Commit();
        }
    }
}
