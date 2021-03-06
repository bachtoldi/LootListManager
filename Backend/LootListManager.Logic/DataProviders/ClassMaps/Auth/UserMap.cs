﻿using FluentNHibernate.Mapping;
using LootListManager.Logic.Entities.Auth;

namespace LootListManager.Logic.DataProviders.ClassMaps.Auth {
  public class UserMap : ClassMap<User> {
    public UserMap() {
      Table("Users");

      Id(u => u.Id);

      Map(u => u.UserName);
      Map(u => u.PasswordHash);
      Map(u => u.UserLoginAttempts);
    }
  }
}