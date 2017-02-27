using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using MusicStoreEF.Models;

namespace MusicStoreEF.Infrastructure
{
    public class DbContextInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IDbContext>().ImplementedBy<DbContext>());
        }
    }
}