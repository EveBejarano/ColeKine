using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ColeKineWebApplication.Startup))]
namespace ColeKineWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
