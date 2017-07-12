using LootListManager.Logic.Entities.Auth;
using LootListManager.Util;

namespace LootListManager.ViewModels {
  public class UserViewModel : LinkViewModel {

    #region - Constructor -

    public UserViewModel(User user) {
      UserId = user.Id;
      UserName = user.UserName;
      CharacterFk = user.CharacterRef.CharacterId;
    }

    #endregion

    #region - Properties -

    public int UserId { get; set; }
    public string UserName { get; set; }
    public int CharacterFk { get; set; }

    #endregion

  }
}