using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RaysRentals.Startup))]
namespace RaysRentals
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
