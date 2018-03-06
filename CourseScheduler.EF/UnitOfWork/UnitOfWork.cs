using CourseScheduler.Core.UnitOfWork.Contracts;
using CourseScheduler.EF.Factories.Contracts;

namespace CourseScheduler.EF.UnitOfWork
{
    public class UnitOfWork
        : IUnitOfWork
    {
        private readonly IDbFactory _dbFactory;

        private CourseSchedulerContext _dbContext;

        public CourseSchedulerContext DbContext => _dbContext ?? (_dbContext = _dbFactory.Init());

        public UnitOfWork(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public void Commit()
        {
            _dbContext.Commit();
        }
    }
}
