using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NICConf_GreenButton.Startup))]
namespace NICConf_GreenButton
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
