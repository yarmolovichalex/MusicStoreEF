using Castle.Windsor;
using Castle.Windsor.Installer;
using System.Web.Mvc;

namespace MusicStoreEF.Infrastructure
{
    public class IocContainer
    {
        private static IWindsorContainer _container;

        public static void Setup()
        {
            _container = new WindsorContainer().Install(FromAssembly.This());

            WindsorControllerFactory controllerFactory = new WindsorControllerFactory(_container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }
    }
}