using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PAYG_Payroll.Startup))]
namespace PAYG_Payroll
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
