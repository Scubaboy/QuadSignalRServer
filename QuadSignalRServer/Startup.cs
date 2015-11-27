namespace QuadSignalRServer
{
    using Microsoft.AspNet.SignalR;
    using Microsoft.Owin.Cors;
    using Owin;
    using QuadSignalRServer.IoC.NinjectIoC;
    using QuadSignalRServer.IoC.NinjectIocC;

    internal class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HubConfiguration();
            config.Resolver = new NinjectSignalRDependencyResolver(KernelBuilder.BuildKernel());

            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR(config);
        }
    }
}
