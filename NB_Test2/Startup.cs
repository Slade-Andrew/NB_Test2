using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NB_Test2.Startup))]
namespace NB_Test2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
