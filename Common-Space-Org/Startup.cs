using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Common_Space_Org.Startup))]
namespace Common_Space_Org
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
