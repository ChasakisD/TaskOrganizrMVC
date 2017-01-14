using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPNetWebApp.Startup))]
namespace ASPNetWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
