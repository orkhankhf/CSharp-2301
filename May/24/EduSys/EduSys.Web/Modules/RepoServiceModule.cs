using Autofac;
using EduSys.Core.Repositories;
using EduSys.Core.Services;
using EduSys.Core.UnitOfWorks;
using EduSys.Repository.Repositories;
using EduSys.Repository.UnitOfWorks;
using EduSys.Repository;
using EduSys.Service.Mapping;
using EduSys.Service.Services;
using System.Reflection;

namespace EduSys.Web.Modules
{
    public class RepoServiceModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var apiAssembly = Assembly.GetExecutingAssembly();

            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));

            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly)
                .Where(x => x.Name.EndsWith("Repository"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly)
                .Where(x => x.Name.EndsWith("Service"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(GenericRepository<>))
                .As(typeof(IGenericRepository<>))
                .InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(Service<>))
                .As(typeof(IService<>))
                .InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
        }
    }
}
