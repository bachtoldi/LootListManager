using LootListManager.Logic.Entities.Auth;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace LootListManager.Logic.DataProviders {
  internal class AuthDataProvider : DataProvider, IAuthDataProvider {

    #region - User -

    public User GetUser(int id) {
      return GetById<User>(id);
    }

    public User GetUserByName(string userName) {
      return GetList<User>().FirstOrDefault(x => x.UserName.Equals(userName));
    }

    public IList<User> GetUsers() {
      return GetList<User>();
    }

    public User SaveUser(User user) {
      Save(user);
      return GetUser(user.Id);
    }

    public bool DeleteUser(User user) {
      Delete(user);
      return GetUser(user.Id) == null;
    }

    #endregion

    #region - Role -

    public Role GetRole(int id) {
      return GetById<Role>(id);
    }

    public Role GetRoleByName(string name) {
      return GetList<Role>().FirstOrDefault(x => x.RoleName.Equals(name));
    }

    public IList<Role> GetRoles() {
      return GetList<Role>();
    }

    public Role SaveRole(Role role) {
      Save(role);
      return GetRole(role.RoleId);
    }

    public bool DeleteRole(Role role) {
      Delete(role);
      return GetRole(role.RoleId) == null;
    }

    #endregion

  }
}
