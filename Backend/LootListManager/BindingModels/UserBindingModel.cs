using LootListManager.Auth;
using LootListManager.Logic.Entities.Auth;

namespace LootListManager.BindingModels {
  public class UserBindingModel {

    #region - Properties -

    public string UserName { get; set; }
    public string UserPassword { get; set; }

    #endregion

    #region - Public Methods -

    public User GetEntity() {
      return new User {
        UserName = UserName,
        PasswordHash = UserPassword,
      };
    }

    public ApplicationUser GetAppUser() {
      return new ApplicationUser(GetEntity());
    }

    #endregion

  }
}