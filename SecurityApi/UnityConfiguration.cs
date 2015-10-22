using Common.Caching;
using Common.Caching.Contracts;
using Microsoft.Practices.Unity;
using SecurityApi.Data;
using SecurityApi.Data.Contracts;
using SecurityApi.Services;
using SecurityApi.Services.Contracts;

namespace SecurityApi
{
    public class UnityConfiguration
    {
        public static IUnityContainer GetContainer(bool useMock = false)
        {
            var container = new UnityContainer();
            container.RegisterType<ISecurityUow, SecurityUow>();
            container.RegisterType<ISecurityContext, SecurityContext>();
            container.RegisterType<ISessionService, SessionService>();
            container.RegisterType<IIdentityService, IdentityService>();
            container.RegisterType<IEncryptionService, EncryptionService>();
            container.RegisterType<ICacheProvider, CacheProvider>();
            container.RegisterType<ISecurityService, SecurityService>();
            return container;
        }
    }
}
