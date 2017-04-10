using LootListManager.Logic.Entities.Auth;
using System.Collections.Generic;

namespace LootListManager.Logic.DataProviders {
  public interface IAuthDataProvider {

    #region - User -

    User GetUser(int id);
    User GetUserByName(string userName);
    IList<User> GetUsers();
    User SaveUser(User user);
    bool DeleteUser(User user);

    #endregion

    #region - Role -

    Role GetRole(int id);
    Role GetRoleByName(string roleName);
    IList<Role> GetRoles();
    Role SaveRole(Role role);
    bool DeleteRole(Role role);

    #endregion

  }
}
