using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhamDucPhat_2011062286_BigSchool.Startup))]
namespace PhamDucPhat_2011062286_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
