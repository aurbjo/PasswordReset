using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PasswordReset.Startup))]
namespace PasswordReset
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
