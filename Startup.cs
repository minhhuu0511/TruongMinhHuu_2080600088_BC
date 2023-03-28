using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TruongMinhHuu_2080600088_BC.Startup))]
namespace TruongMinhHuu_2080600088_BC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
