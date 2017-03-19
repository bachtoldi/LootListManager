using LootListManager.Entities;
using FluentNHibernate.Mapping;

namespace LootListManager.DataProviders.ClassMaps {
  public class TokenMap : ClassMap<Token> {
    public TokenMap() {
      Table("Tokens");

      Id(t => t.TokenId);

      Map(t => t.AuthToken);
      Map(t => t.IssuedOn);
      Map(t => t.ExpiresOn);

      References<User>(t => t.UserRef, "FK_UserId");
    }
  }
}