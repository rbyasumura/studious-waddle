using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(studious_waddle.Startup))]
namespace studious_waddle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
