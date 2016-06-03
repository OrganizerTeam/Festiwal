using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Festival.Startup))]
namespace Festival
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
