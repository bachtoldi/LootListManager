using LootListManager.Logic.DataProviders;
using LootListManager.Logic.Entities.Auth;
using System.Collections.Generic;
using System.Globalization;

namespace LootListManager.Connectors {
  internal class AuthControllerDataConnector {

    #region - Instance Variables -

    private readonly IAuthDataProvider _authConnector;

    #endregion

    #region - Constructor -

    public AuthControllerDataConnector() {
      _authConnector = DataProviderFactory.GetAuthDataProvider();
    }

    #endregion

    #region - User -

    public User GetUser(int id) {
      return _authConnector.GetUser(id);
    }

    public IList<User> GetUsers() {
      return _authConnector.GetUsers();
    }

    public void SaveUser(User user) {
      _authConnector.SaveUser(user);
    }

    public void DeleteUser(int id) {
      _authConnector.DeleteUser(id);
    }

    #endregion

  }
}