using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup(typeof(FacebookClone.Startup))]

namespace FacebookClone
{
    [HubName("echo")]
    public class Startup
    {
        
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
