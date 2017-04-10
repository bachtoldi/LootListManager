using LootListManager.Logic.Entities.Auth;
using Microsoft.AspNet.Identity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LootListManager.Auth {
  public class ApplicationUser : IUser<int> {

    public User User { get; set; }

    public int Id {
      get {
        return User.Id;
      }
      set {
        User.Id = value;
      }
    }

    public string UserName {
      get {
        return User.UserName;
      }
      set {
        User.UserName = value;
      }
    }

    public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser, int> manager, string authenticationType) {
      var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
      //Add custom user claims here
      return userIdentity;
    }

    public ApplicationUser(User user) {
      User = user;
    }

  }
}