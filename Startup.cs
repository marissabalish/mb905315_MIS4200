using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mb905315_MIS4200.Startup))]
namespace mb905315_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
