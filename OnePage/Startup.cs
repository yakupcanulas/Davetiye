using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnePage.Startup))]
namespace OnePage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
