using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eSKImo.Startup))]
namespace eSKImo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
