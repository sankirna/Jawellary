using System.ComponentModel;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;

namespace Jewellery.Web
{
    /// <summary>
    /// Inject Dependencies which are registered here with Container Builder.
    /// </summary>
    public class IocConfig
    {
        public static void RegisterDependencies()
        {
            //ContainerBuilder containerBuilder = new ContainerBuilder();
            //// Register all controllers.
            //containerBuilder.RegisterControllers(typeof(BaseController).Assembly);

            //// Register HttpContextBase.
            //containerBuilder.RegisterType(typeof(HttpContextBase));

            //// Register Libs.
            //containerBuilder.RegisterAssemblyTypes(typeof(HomeLib).Assembly).Where(t => t.Name.EndsWith("Lib")).InstancePerLifetimeScope();

            //// Register other dependencies.
            //containerBuilder.RegisterType<GoByMobilePortalDbContext>().As<DbContext>().InstancePerDependency();
            //containerBuilder.RegisterGeneric(typeof(DataRepository<>)).As(typeof(IDataRepository<>)).InstancePerDependency();
            //containerBuilder.RegisterType<WebSecurityWrapper>().As<IWebSecurity>();
            //containerBuilder.RegisterType<RoleWrapper>().As<IRole>();
            //containerBuilder.RegisterType<RolePrincipalWrapper>().As<IRolePrincipal>();
            //containerBuilder.RegisterType<AppSettingsHelper>().As<IAppSettingsHelper>();

            //IContainer container = containerBuilder.Build();
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            //GlobalUtil.Container = container;
        }
    }
}