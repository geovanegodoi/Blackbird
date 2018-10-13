using System;
using Blackbird.Commom.Mapper;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Blackbird.Commom.IoC
{
    public class IoCInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<TransactionInterceptor>().LifestyleSingleton());

            container.Register(Component.For<LoggerInterceptor>().LifestyleSingleton());

            //container.Register(Component.For<BlackbirdDbContext>)

            container.Register(Classes.FromAssemblyInDirectory(new AssemblyFilter(AppContext.BaseDirectory))
                     .BasedOn<IAutoMapperInitializer>()
                     .LifestyleSingleton()
                     .WithServiceAllInterfaces()
                     .AllowMultipleMatches());

            container.Register(Classes.FromAssemblyInDirectory(new AssemblyFilter(AppContext.BaseDirectory))
                     .BasedOn<IControllerLifestyle>() 
                     .WithServiceAllInterfaces()
                     .LifestyleSingleton()
                     .AllowMultipleMatches());

            container.Register(Classes.FromAssemblyInDirectory(new AssemblyFilter(AppContext.BaseDirectory))
                     .BasedOn<IServiceLifestyle>()
                     .WithServiceAllInterfaces()
                     .LifestyleSingleton()
                     .AllowMultipleMatches());

            container.Register(Classes.FromAssemblyInDirectory(new AssemblyFilter(AppContext.BaseDirectory))
                     .BasedOn<IRepositoryLifestyle>()
                     .WithServiceAllInterfaces()
                     .ConfigureFor<IRepositoryLifestyle>(a => 
                     {
                         a.Interceptors<TransactionInterceptor>();
                     })
                     .LifestyleSingleton()
                     .AllowMultipleMatches());                               
        }
    }
}
