using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(List.Startup))]
namespace List
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
