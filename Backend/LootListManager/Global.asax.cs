using System.Web;
using System.Web.Http;
using Unity.WebApi;

namespace LootListManager {
  public class Global : HttpApplication {
    protected void Application_Start() {
      GlobalConfiguration.Configure(WebApiConfig.Register);

      GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(UnityRegistration.Container);
    }
  }
}