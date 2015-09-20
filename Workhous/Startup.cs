using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Workhous.Startup))]
namespace Workhous
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
