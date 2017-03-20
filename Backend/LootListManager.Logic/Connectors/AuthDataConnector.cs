﻿using LootListManager.Logic.DataProviders;
using LootListManager.Logic.Entities.Auth;
using System.Collections.Generic;

namespace LootListManager.Logic.Connectors {
  internal class AuthDataConnector : DataProvider, IAuthDataConnector {

    #region - User -

    public User GetUser(int id) {
      return GetById<User>(id);
    }

    public IList<User> GetUsers() {
      return GetList<User>();
    }

    public User SaveUser(User user) {
      Save(user);
      return GetById<User>(user.UserId);
    }

    public bool DeleteUser(int id) {
      var user = GetUser(id);
      Delete(user);
      return GetById<User>(user.UserId) == null;
    }

    #endregion

  }
}
