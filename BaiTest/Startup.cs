using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaiTest.Startup))]
namespace BaiTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
