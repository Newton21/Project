using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UniversityMgtSystem.Startup))]
namespace UniversityMgtSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
