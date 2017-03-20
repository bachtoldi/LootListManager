using FluentNHibernate.Mapping;
using LootListManager.Logic.Entities.Player;

namespace LootListManager.Logic.DataProviders.ClassMaps.Player {
  public class CharacterMap : ClassMap<Character> {
    public CharacterMap() {
      Table("Characters");

      Id(c => c.CharacterId);

      Map(c => c.CharacterName);

      References(c => c.UserRef, "FK_UserId");
      References(c => c.RaceRef, "FK_RaceId");
      References(c => c.TalentRef, "FK_TalentId");
    }
  }
}