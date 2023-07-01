using Module = Autofac.Module;
using System.Reflection;
using EduSys.Repository;
using EduSys.Service.Mapping;
using Autofac;
using EduSys.Repository.UnitOfWorks;
using EduSys.Core.UnitOfWorks;
using EduSys.Repository.Repositories;
using EduSys.Core.Repositories;
using EduSys.Service.Services;
using EduSys.Core.Services;
using EduSys.Caching;

namespace EduSys.API.Modules
{
    public class RepoServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var apiAssembly = Assembly.GetExecutingAssembly();

            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));

            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly)
                .Where(x=>x.Name.EndsWith("Repository"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly)
                .Where(x => x.Name.EndsWith("Service"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            //builder.RegisterType<ProductServiceWithCaching>().As<IProductService>();

            builder.RegisterGeneric(typeof(GenericRepository<>))
                .As(typeof(IGenericRepository<>))
                .InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(Service<>))
                .As(typeof(IService<>))
                .InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            /*
             152.148.13.4:443 <= web project
             152.148.13.4:52777 <- API project

             API:
             Http:(5159)
             Https:(7133)

             WEB:
             Http:(5022)
             Https:(7120)
             */
        }
    }
}
