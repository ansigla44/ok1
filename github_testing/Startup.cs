using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(github_testing.Startup))]
namespace github_testing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
