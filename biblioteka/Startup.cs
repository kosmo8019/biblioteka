using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(biblioteka.Startup))]
namespace biblioteka
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
