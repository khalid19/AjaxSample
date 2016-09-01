using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JqueryAjaxJsonSample.Startup))]
namespace JqueryAjaxJsonSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
