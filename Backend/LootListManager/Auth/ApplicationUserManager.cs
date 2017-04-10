using LootListManager.Logic.Entities.Auth;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LootListManager.Auth {
  public class ApplicationUserManager : UserManager<ApplicationUser, int> {

    public ApplicationUserManager(IUserStore<ApplicationUser, int> store)
      : base(store) { }

    public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options, IOwinContext context) {
      var manager = new ApplicationUserManager(new ApplicationUserStore<ApplicationUser>());

      manager.UserValidator = new UserValidator<ApplicationUser, int>(manager) { 
        AllowOnlyAlphanumericUserNames = false,
        RequireUniqueEmail = false,
      };

      manager.PasswordValidator = new PasswordValidator {
        RequiredLength = 4,
        RequireNonLetterOrDigit = false,
        RequireDigit = false,
        RequireLowercase = false,
        RequireUppercase = false,
      };

      //manager.PasswordHasher = new ApplicationPasswordHasher();

      var dataProtectionProvider = options.DataProtectionProvider;
      if(dataProtectionProvider != null) {
        manager.UserTokenProvider = new DataProtectorTokenProvider<ApplicationUser, int>(dataProtectionProvider.Create("Identity Authorization"));
      }

      return manager;
    }

  }
}