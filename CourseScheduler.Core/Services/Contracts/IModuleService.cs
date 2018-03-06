using CourseScheduler.Domain.Models;

namespace CourseScheduler.Core.Services.Contracts
{
    public interface IModuleService
    {
        void CreateModule(Module module);
        void SaveModule();
    }
}
