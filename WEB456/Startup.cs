using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WEB456.Startup))]
namespace WEB456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
