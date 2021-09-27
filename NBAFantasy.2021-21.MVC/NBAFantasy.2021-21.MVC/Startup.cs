using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NBAFantasy._2021_21.MVC.Startup))]
namespace NBAFantasy._2021_21.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
