using FluentNHibernate.Mapping;
using LootListManager.Logic.Entities.Player;

namespace LootListManager.Logic.DataProviders.ClassMaps.Player {
  public class TalentMap : ClassMap<Talent> {
    public TalentMap() {
      Table("Talents");

      Id(t => t.TalentId);

      Map(t => t.TalentLogicalId);

      References(t => t.ClassRef, "FK_ClassId").Cascade.None().Not.LazyLoad();
    }
  }
}