using CourseScheduler.Core.Repositories.Contracts;
using CourseScheduler.Core.Services.Contracts;

namespace CourseScheduler.Core.Services
{
    public class ModuleDataService
        : IModuleDataService
    {
        private readonly IModuleRepository _moduleRepository;

        public ModuleDataService(IModuleRepository moduleRepository)
        {
            _moduleRepository = moduleRepository;
        }
    }
}
