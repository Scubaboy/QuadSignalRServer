using Microsoft.Owin;
using QuadSignalRServer;
[assembly: OwinStartup(typeof(Startup))] 
namespace QuadSignalRServer
{
    using Microsoft.AspNet.SignalR;

    using Microsoft.Owin.Cors;
    using Owin;
    using QuadSignalRServer.IoC.NinjectIoC;
    using QuadSignalRServer.IoC.NinjectIocC;
    using System;

    
    internal class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            try
            {
                var config = new HubConfiguration();
               config.Resolver = new NinjectSignalRDependencyResolver(KernelBuilder.BuildKernel());

                app.UseCors(CorsOptions.AllowAll);
                app.MapSignalR(config);
            }
            catch (Exception exp)
            {
                var msg = exp.Message;
            }
        }
    }
}
