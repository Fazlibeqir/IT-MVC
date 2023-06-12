using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Album.Startup))]
namespace Album
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
