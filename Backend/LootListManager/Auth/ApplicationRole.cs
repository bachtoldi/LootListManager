using LootListManager.Logic.Entities.Auth;
using Microsoft.AspNet.Identity;

namespace LootListManager.Auth {
  public class ApplicationRole : IRole<int> {

    public ApplicationRole(Role role) {
      Role = role;
    }

    public Role Role { get; set; }

    public int Id {
      get {
        return Role.RoleId;
      }
      set {
        Role.RoleId = value;
      }
    }

    public string Name {
      get {
        return Role.RoleName;
      }
      set {
        Role.RoleName = value;
      }
    }

  }
}