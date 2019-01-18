using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using SmartTechApi.Infrastructure;

[assembly: OwinStartup(typeof(SmartTechApi.Startup))]

namespace SmartTechApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            AutoMapperConfiguration.Init();
        }
    }
}
