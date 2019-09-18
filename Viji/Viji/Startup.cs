using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Viji.Startup))]
namespace Viji
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
