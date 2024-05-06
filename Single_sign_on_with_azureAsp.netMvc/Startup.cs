using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

namespace Single_sign_on_with_azureAsp.netMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
