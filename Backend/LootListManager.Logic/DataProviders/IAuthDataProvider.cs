using LootListManager.Logic.Entities.Auth;
using System.Collections.Generic;

namespace LootListManager.Logic.DataProviders {
  public interface IAuthDataProvider {

    #region - User -

    User GetUser(int id);
    IList<User> GetUsers();
    User SaveUser(User user);
    bool DeleteUser(int id);

    #endregion

  }
}
