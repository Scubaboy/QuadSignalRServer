namespace QuadSignalRServer.Hubs.ActiveQuads
{
    using Microsoft.AspNet.SignalR;
    using Microsoft.AspNet.SignalR.Hubs;
    using System.Threading.Tasks;

    [HubName("ActiveQuadsHub")]
    public class ActiveQuadsHub : Hub
    {
        public override Task OnConnected()
        {
            return base.OnConnected();
        }
    }
}
