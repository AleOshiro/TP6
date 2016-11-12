using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TP6.Startup))]
namespace TP6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
