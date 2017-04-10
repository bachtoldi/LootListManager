using LootListManager.Logic.DataProviders;
using Microsoft.AspNet.Identity;
using System.Threading.Tasks;

namespace LootListManager.Auth {
  public class ApplicationUserStore<T> : IUserStore<ApplicationUser, int>, IUserPasswordStore<ApplicationUser, int> where T : ApplicationUser {

    #region - Instance Variables -

    private readonly IAuthDataProvider _authDataProvider;

    #endregion

    #region - Constructor -

    public ApplicationUserStore() {
      _authDataProvider = DataProviderFactory.GetAuthDataProvider();
    }

    #endregion

    #region -- CreateAsync --

    public async Task CreateAsync(ApplicationUser user) {
      await Task.FromResult(_authDataProvider.SaveUser(user.User));
    }

    #endregion

    #region -- DeleteAsync --

    public async Task DeleteAsync(ApplicationUser user) {
      await Task.Run(() => _authDataProvider.DeleteUser(user.User));
    }

    #endregion

    #region -- FindByIdAsync --

    public async Task<ApplicationUser> FindByIdAsync(int userId) {
      var user = _authDataProvider.GetUser(userId);
      return await Task.FromResult(new ApplicationUser(user));
    }

    #endregion

    #region -- FindByNameAsync --

    public async Task<ApplicationUser> FindByNameAsync(string userName) {
      var user = _authDataProvider.GetUserByName(userName);
      return await Task.FromResult(new ApplicationUser(user));
    }

    #endregion

    #region -- UpdateAsync --

    public async Task UpdateAsync(ApplicationUser user) {
      await Task.FromResult(_authDataProvider.SaveUser(user.User));
    }

    #endregion

    #region -- GetPasswordHashAsync --

    public Task<string> GetPasswordHashAsync(ApplicationUser user) {
      if (user.User != null) {
        return Task.FromResult(user.User.PasswordHash);
      } else {
        return Task.FromResult(string.Empty);
      }
    }

    #endregion

    #region -- HasPasswordAsync --

    public Task<bool> HasPasswordAsync(ApplicationUser user) {
      return Task.FromResult(!string.IsNullOrWhiteSpace(user.User.PasswordHash));
    }

    #endregion

    #region -- SetPasswordHashAsync --

    public Task SetPasswordHashAsync(ApplicationUser user, string passwordHash) {
      user.User.PasswordHash = passwordHash;
      return Task.FromResult(new ApplicationUser(_authDataProvider.SaveUser(user.User)));
    }

    #endregion

    #region -- Dispose --

    public void Dispose() { }

    #endregion

  }
}