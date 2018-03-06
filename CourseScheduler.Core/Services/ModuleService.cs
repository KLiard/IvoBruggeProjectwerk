using CourseScheduler.Core.Repositories.Contracts;
using CourseScheduler.Core.Services.Contracts;
using CourseScheduler.Core.UnitOfWork.Contracts;
using CourseScheduler.Domain.Models;

namespace CourseScheduler.Core.Services
{
    public class ModuleService
        : IModuleService
    {
        private readonly IModuleRepository _moduleRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ModuleService(IModuleRepository moduleRepository, IUnitOfWork unitOfWork)
        {
            _moduleRepository = moduleRepository;
            _unitOfWork = unitOfWork;
        }

        public void CreateModule(Module module)
        {
            _moduleRepository.Add(module);
        }

        public void SaveModule()
        {
            _unitOfWork.Commit();
        }
    }
}
