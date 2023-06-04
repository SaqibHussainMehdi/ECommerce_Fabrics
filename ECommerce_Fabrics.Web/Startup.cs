using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ECommerce_Fabrics.Web.Startup))]
namespace ECommerce_Fabrics.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
