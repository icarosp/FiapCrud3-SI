using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrudAM.Startup))]
namespace CrudAM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
