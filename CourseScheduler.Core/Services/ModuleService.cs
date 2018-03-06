using CourseScheduler.Core.Repositories.Contracts;
using CourseScheduler.Core.Services.Contracts;

namespace CourseScheduler.Core.Services
{
    public class ModuleService
        : IModuleService
    {
        private readonly IModuleRepository _moduleRepository;

        public ModuleService(IModuleRepository moduleRepository)
        {
            _moduleRepository = moduleRepository;
        }
    }
}
