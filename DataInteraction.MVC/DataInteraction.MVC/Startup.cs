using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataInteraction.MVC.Startup))]
namespace DataInteraction.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
