using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab2JSweany.Startup))]
namespace Lab2JSweany
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
