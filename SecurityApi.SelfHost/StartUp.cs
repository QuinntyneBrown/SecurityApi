using System.Web.Http;
using Owin;
using Unity.WebApi;

namespace SecurityApi.SelfHost
{
    public class StartUp
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var config = new HttpConfiguration();

            config.DependencyResolver = new UnityDependencyResolver(SecurityApi.UnityConfiguration.GetContainer());

            ApiConfiguration.Install(config, appBuilder);

            appBuilder.UseWebApi(config);
        }
    }
}
