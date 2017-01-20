using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicStoreEF.Startup))]
namespace MusicStoreEF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
