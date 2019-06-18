using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoLWebsite.Startup))]
namespace LoLWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
