using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleClub.Web.Startup))]
namespace SimpleClub.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
