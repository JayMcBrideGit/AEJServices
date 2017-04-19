using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AEJServices.Startup))]
namespace AEJServices
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
