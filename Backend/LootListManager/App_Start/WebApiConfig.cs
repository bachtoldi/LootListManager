using System.Web.Http;

namespace LootListManager {
  public static class WebApiConfig {
    public static void Register(HttpConfiguration config) {
      config.MapHttpAttributeRoutes();
    }
  }
}