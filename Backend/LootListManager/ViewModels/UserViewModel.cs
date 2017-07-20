using LootListManager.Logic.Entities.Auth;
using LootListManager.Util;

namespace LootListManager.ViewModels {
  public class UserViewModel : LinkViewModel {

    #region - Constructor -

    public UserViewModel(User user) {
      UserId = user.Id;
      UserName = user.UserName;
    }

    #endregion

    #region - Properties -

    public int UserId { get; set; }
    public string UserName { get; set; }

    #endregion

  }
}