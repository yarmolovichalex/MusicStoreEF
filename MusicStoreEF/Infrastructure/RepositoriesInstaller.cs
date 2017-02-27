using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using MusicStoreEF.Repositories;

namespace MusicStoreEF.Infrastructure
{
    public class RepositoriesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly()
                .InSameNamespaceAs<ArtistRepository>()
                .WithServiceDefaultInterfaces()
                .LifestylePerWebRequest());
        }
    }
}