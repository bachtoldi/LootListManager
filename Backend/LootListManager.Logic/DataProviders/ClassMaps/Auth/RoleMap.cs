using FluentNHibernate.Mapping;
using LootListManager.Logic.Entities.Auth;

namespace LootListManager.Logic.DataProviders.ClassMaps.Auth {
  public class RoleMap : ClassMap<Role> {
    public RoleMap() {
      Table("Roles");

      Id(r => r.RoleId);

      Map(r => r.RoleName);
    }
  }
}
