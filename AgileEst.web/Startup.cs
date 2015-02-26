using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AgileEst.web.Startup))]
namespace AgileEst.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
