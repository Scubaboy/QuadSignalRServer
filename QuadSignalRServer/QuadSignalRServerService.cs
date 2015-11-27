using Microsoft.Owin;
using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(QuadSignalRServer.Startup))]

namespace QuadSignalRServer
{
    public partial class QuadSignalRServerService : ServiceBase
    {
        IDisposable signalR;
        EventLog eventLog1 = new EventLog();

        public QuadSignalRServerService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (!System.Diagnostics.EventLog.SourceExists("QuadSignalRServer"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    "QuadSignalRServer", "Application");
            }
            eventLog1.Source = "QuadSignalRServer";
            eventLog1.Log = "Application";

            eventLog1.WriteEntry("In OnStart");
            string url = "http://localhost:8080";
            signalR = WebApp.Start(url); 
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("In OnStop");
            signalR.Dispose();
        }
    }
}
