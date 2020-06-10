using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BecasITT_v1._1.Startup))]
namespace BecasITT_v1._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
