using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentTrackerWeb.Startup))]
namespace StudentTrackerWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
