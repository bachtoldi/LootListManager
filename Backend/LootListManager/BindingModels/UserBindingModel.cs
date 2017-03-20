using LootListManager.Logic.Entities.Auth;

namespace LootListManager.BindingModels {
  public class UserBindingModel {

    #region - Properties -

    public string UserName { get; set; }
    public string UserPasswordHash { get; set; }

    #endregion

    #region - Public Methods -

    public User GetEntity() {
      return new User {
        UserName = UserName,
        UserPasswordHash = UserPasswordHash,
      };
    }

    #endregion

  }
}