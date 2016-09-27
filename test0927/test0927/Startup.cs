using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test0927.Startup))]
namespace test0927
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
