using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace GomPlayer.Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<GomPlayer.IApplication.IDeviceService, GomPlayer.Application.DeviceService>();
            container.RegisterType<GomPlayer.Domain.Repositories.IRepositoryContext, GomPlayer.Infrastructure.Repositories.EntityFramework.GomPlayerRepositoryContext>();
            container.RegisterType<GomPlayer.Domain.Repositories.IDeviceRepository, GomPlayer.Infrastructure.Repositories.EntityFramework.DeviceRepository>();
            container.RegisterType<GomPlayer.Domain.Repositories.ISmsRepository, GomPlayer.Infrastructure.Repositories.EntityFramework.SmsRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}