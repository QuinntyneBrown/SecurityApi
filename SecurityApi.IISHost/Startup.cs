using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Owin;
using Unity.WebApi;

[assembly: OwinStartup(typeof(SecurityApi.IISHost.Startup))]

namespace SecurityApi.IISHost
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(SecurityApi.UnityConfiguration.GetContainer());

            GlobalConfiguration.Configure(config => SecurityApi.ApiConfiguration.Install(config, app));
        }
    }
}
