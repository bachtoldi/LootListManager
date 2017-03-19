using FluentNHibernate.Mapping;
using LootListManager.Entities;

namespace LootListManager.DataProviders.ClassMaps {
  public class UserMap : ClassMap<User> {
    public UserMap() {
      Table("Users");

      Id(u => u.UserId);

      Map(u => u.UserName);
      Map(u => u.UserPasswordHash);
      Map(u => u.UserLoginAttempts);
    }
  }
}