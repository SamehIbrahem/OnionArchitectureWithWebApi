using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;
using SmartTechApi.Infrastructure;

[assembly: OwinStartup(typeof(SmartTechApi.Startup))]

namespace SmartTechApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            AutoMapperConfiguration.Init();
        }
    }
}
