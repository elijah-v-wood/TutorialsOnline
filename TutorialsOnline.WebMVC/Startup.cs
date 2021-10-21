using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TutorialsOnline.WebMVC.Startup))]
namespace TutorialsOnline.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
