using AutoMapper;
using CourseScheduler.Domain.Models;
using CourseScheduler.Dto.Models;

namespace CourseScheduler.AutoMapper.Mapper.Profiles
{
    public class ModuleProfile
        : Profile
    {
        public override string ProfileName => nameof(ModuleProfile);

        public ModuleProfile()
        {
            // Map the domain class to the Dto class and back
            CreateMap<Module, ModuleDto>().ReverseMap();

            // Map the Dto class to the ViewModel and back
        }
    }
}