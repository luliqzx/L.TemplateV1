using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(L.TemplateV1.Web.Startup))]
namespace L.TemplateV1.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
