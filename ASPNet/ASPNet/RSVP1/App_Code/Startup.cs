using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RSVP1.Startup))]
namespace RSVP1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
