using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmarTT.Startup))]
namespace SmarTT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
