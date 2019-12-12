using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Juarezweb1.Startup))]
namespace Juarezweb1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
