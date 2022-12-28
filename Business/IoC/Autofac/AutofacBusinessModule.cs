using Autofac;
using AutoMapper;
using Business.Abstract;
using Business.Concrete;
using Business.Mapping.AutoMapper;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.IoC.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfCustomerRepository>().As<ICustomerRepository>();
            builder.RegisterType<CustomerService>().As<ICustomerService>();

            #region AutoMapper Register
            builder.Register(context => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfiles>();
            }
            )).AsSelf().SingleInstance();

            builder.Register(c =>
            {
                var context = c.Resolve<IComponentContext>();
                var config = context.Resolve<MapperConfiguration>();
                return config.CreateMapper(context.Resolve);
            })
            .As<IMapper>()
            .InstancePerLifetimeScope();
            #endregion
        }
    }
}