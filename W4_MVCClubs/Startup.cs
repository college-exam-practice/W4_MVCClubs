using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(W4_MVCClubs.Startup))]
namespace W4_MVCClubs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
