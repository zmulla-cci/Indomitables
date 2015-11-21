using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_Interview.Startup))]
namespace E_Interview
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
