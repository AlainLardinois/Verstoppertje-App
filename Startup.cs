using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VerstoppertjeApp.Startup))]
namespace VerstoppertjeApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
