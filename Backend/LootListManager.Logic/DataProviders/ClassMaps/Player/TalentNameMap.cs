using FluentNHibernate.Mapping;
using LootListManager.Logic.Entities.Player;

namespace LootListManager.Logic.DataProviders.ClassMaps.Player {
  public class TalentNameMap : ClassMap<TalentName> {
    public TalentNameMap() {
      Table("TalentNames");

      Id(t => t.TalentNameId);

      Map(t => t.TalentNameCulture);
      Map(t => t.TalentNameString);

      References(t => t.TalentRef, "FK_TalentId");
    }
  }
}