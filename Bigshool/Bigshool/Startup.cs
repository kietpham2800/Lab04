using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bigshool.Startup))]
namespace Bigshool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
