using LootListManager.Logic.DataProviders;
using LootListManager.Logic.Entities.Auth;
using System.Collections.Generic;

namespace LootListManager.Connectors {
  internal class AuthDataConnector {

    #region - Instance Variables -

    private readonly IAuthDataProvider _dataProvider;

    #endregion

    #region - Constructor -

    public AuthDataConnector() {
      _dataProvider = DataProviderFactory.GetAuthDataProvider();
    }

    #endregion

    #region - User -

    public User GetUser(int id) {
      return _dataProvider.GetUser(id);
    }

    public IList<User> GetUsers() {
      return _dataProvider.GetUsers();
    }

    public void SaveUser(User user) {
      _dataProvider.SaveUser(user);
    }

    public void DeleteUser(int id) {
      _dataProvider.DeleteUser(GetUser(id));
    }

    #endregion

  }
}