using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab8_AuthWithGoogle.Startup))]
namespace Lab8_AuthWithGoogle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
