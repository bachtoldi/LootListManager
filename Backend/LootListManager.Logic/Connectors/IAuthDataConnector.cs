using LootListManager.Logic.Entities.Auth;
using System.Collections.Generic;

namespace LootListManager.Logic.Connectors {
  public interface IAuthDataConnector {

    #region - User -

    User GetUser(int id);
    IList<User> GetUsers();
    User SaveUser(User user);
    bool DeleteUser(int id);

    #endregion

  }
}
