using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NoteEleven.Startup))]
namespace NoteEleven
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
