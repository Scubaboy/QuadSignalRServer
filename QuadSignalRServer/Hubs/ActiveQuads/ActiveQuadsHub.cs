namespace QuadSignalRServer.Hubs.ActiveQuads
{
    using Microsoft.AspNet.SignalR;
    using Microsoft.AspNet.SignalR.Hubs;
    using QuadModels;
    using System.Threading.Tasks;

    [HubName("ActiveQuadsHub")]
    public class ActiveQuadsHub : Hub
    {
        public void Test()
        {
            var im = "w";
        }

        public void UpdateQuad(ActiveQuad activeQuad)
        {
            var quad = activeQuad;
        }
        public override Task OnConnected()
        {
            return base.OnConnected();
        }
    }
}
