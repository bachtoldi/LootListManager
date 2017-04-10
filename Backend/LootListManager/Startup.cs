using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(LootListManager.Startup))]

namespace LootListManager {
  public partial class Startup {
    public void Configuration(IAppBuilder app) {
      ConfigureAuth(app);
    }
  }
}