using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab3B.Startup))]
namespace Lab3B
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
