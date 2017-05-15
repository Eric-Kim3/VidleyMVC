using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidleyMVC.Startup))]
namespace VidleyMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
