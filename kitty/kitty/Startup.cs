using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(kitty.Startup))]

namespace kitty
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR(); 
        }
    }
}
