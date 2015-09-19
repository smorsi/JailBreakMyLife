using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JailBreaker.Startup))]
namespace JailBreaker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
