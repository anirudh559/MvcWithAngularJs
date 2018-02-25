using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCWithAngularJs.Startup))]
namespace MVCWithAngularJs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
