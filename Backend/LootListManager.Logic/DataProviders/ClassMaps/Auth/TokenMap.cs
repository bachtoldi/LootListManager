using FluentNHibernate.Mapping;
using LootListManager.Logic.Entities.Auth;

namespace LootListManager.Logic.DataProviders.ClassMaps.Auth {
  public class TokenMap : ClassMap<Token> {
    public TokenMap() {
      Table("Tokens");

      Id(t => t.TokenId);

      Map(t => t.AuthToken);
      Map(t => t.IssuedOn);
      Map(t => t.ExpiresOn);

      References(t => t.UserRef, "FK_UserId").Cascade.None();
    }
  }
}