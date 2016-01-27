using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SportSolution.Startup))]
namespace SportSolution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
