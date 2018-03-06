using System.Reflection;

namespace CourseScheduler.AutoMapper.Mapper
{
    public static class AutoMapperConfig
    {
        public static void Init()
        {
            global::AutoMapper.Mapper
                .Initialize(cfg => cfg.AddProfiles(Assembly.GetCallingAssembly()));
        }
    }
}