using System;

namespace CourseScheduler.EF.Factories.Contracts
{
    public interface IDbFactory
        : IDisposable
    {
        CourseSchedulerContext Init();
    }
}