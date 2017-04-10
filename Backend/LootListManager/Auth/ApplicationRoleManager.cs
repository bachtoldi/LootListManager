using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

namespace LootListManager.Auth {
  public class ApplicationRoleManager : RoleManager<ApplicationRole, int> {

    #region - Constructor -

    public ApplicationRoleManager(ApplicationRoleStore store) : base(store) { }

    #endregion

    #region - Public Methods -

    public static ApplicationRoleManager Create(IdentityFactoryOptions<ApplicationRoleManager> options, IOwinContext context) {
      var store = new ApplicationRoleStore();
      return new ApplicationRoleManager(store);
    }

    #endregion

  }
}