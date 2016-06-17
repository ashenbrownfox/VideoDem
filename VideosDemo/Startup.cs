using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideosDemo.Startup))]
namespace VideosDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
