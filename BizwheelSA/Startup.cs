using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BizwheelSA.Startup))]
namespace BizwheelSA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
