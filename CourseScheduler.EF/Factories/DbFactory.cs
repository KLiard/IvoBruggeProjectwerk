using CourseScheduler.EF.Factories.Contracts;

namespace CourseScheduler.EF.Factories
{
    public class DbFactory
        : Disposable, IDbFactory
    {
        private CourseSchedulerContext _dbContext;

        public CourseSchedulerContext Init()
        {
            return _dbContext ?? (_dbContext = new CourseSchedulerContext());
        }

        protected override void DisposeCore()
        {
            _dbContext?.Dispose();
        }
    }
}