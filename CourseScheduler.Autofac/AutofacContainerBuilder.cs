using Autofac;
using CourseScheduler.Core.UnitOfWork.Contracts;
using CourseScheduler.EF.UnitOfWork;
using System;

namespace CourseScheduler.Autofac
{
    public class AutofacContainerBuilder
    {
        public static IContainer Build(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                .Where(b => b.Name.EndsWith("Repository"))
                .AsImplementedInterfaces()
                .InstancePerRequest();

            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                .Where(b => b.Name.EndsWith("Service"))
                .AsImplementedInterfaces()
                .InstancePerRequest();

            builder.RegisterType<UnitOfWork>()
                .As<IUnitOfWork>()
                .InstancePerRequest();

            return builder.Build();
        }
    }
}
