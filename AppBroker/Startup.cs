using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppBroker.Startup))]
namespace AppBroker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
