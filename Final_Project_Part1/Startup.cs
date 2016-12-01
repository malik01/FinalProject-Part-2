using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Final_Project_Part1.Startup))]
namespace Final_Project_Part1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
