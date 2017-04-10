using LootListManager.Logic.DataProviders;
using Microsoft.AspNet.Identity;
using System.Threading.Tasks;

namespace LootListManager.Auth {
  public class ApplicationRoleStore : IRoleStore<ApplicationRole, int> {

    #region - Instance Variables -

    private readonly IAuthDataProvider _dataProvider;

    #endregion

    #region - Constructor -

    public ApplicationRoleStore() {
      _dataProvider = DataProviderFactory.GetAuthDataProvider();
    }

    #endregion

    #region - Public Methods -
    
    public Task CreateAsync(ApplicationRole role) {
      return Task.FromResult(new ApplicationRole(_dataProvider.SaveRole(role.Role)));
    }
    
    public Task DeleteAsync(ApplicationRole role) {
      return Task.Run(() => _dataProvider.DeleteRole(role.Role));
    }
    
    public Task<ApplicationRole> FindByIdAsync(int roleId) {
      return Task.FromResult(new ApplicationRole(_dataProvider.GetRole(roleId)));
    }
    
    public Task<ApplicationRole> FindByNameAsync(string roleName) {
      return Task.FromResult(new ApplicationRole(_dataProvider.GetRoleByName(roleName)));
    }
    
    public Task UpdateAsync(ApplicationRole role) {
      return Task.FromResult(new ApplicationRole(_dataProvider.SaveRole(role.Role)));
    }
    
    public void Dispose() { }

    #endregion

  }
}