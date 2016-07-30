using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Intermediario.Startup))]
namespace MVC_Intermediario
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
