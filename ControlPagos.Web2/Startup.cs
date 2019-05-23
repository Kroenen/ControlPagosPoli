using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControlPagos.Web2.Startup))]
namespace ControlPagos.Web2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
