using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Allowance.Startup))]
namespace Allowance
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
