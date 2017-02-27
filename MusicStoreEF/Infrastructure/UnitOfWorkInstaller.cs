using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using MusicStoreEF.Core;
using MusicStoreEF.Persistence;

namespace MusicStoreEF.Infrastructure
{
    public class UnitOfWorkInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IUnitOfWork>().ImplementedBy<UnitOfWork>());
        }
    }
}