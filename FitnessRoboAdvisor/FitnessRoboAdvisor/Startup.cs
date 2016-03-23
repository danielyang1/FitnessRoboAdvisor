using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FitnessRoboAdvisor.Startup))]
namespace FitnessRoboAdvisor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
