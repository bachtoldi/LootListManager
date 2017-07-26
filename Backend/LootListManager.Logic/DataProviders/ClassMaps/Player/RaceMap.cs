using FluentNHibernate.Mapping;
using LootListManager.Logic.Entities.Player;

namespace LootListManager.Logic.DataProviders.ClassMaps.Player {
  public class RaceMap : ClassMap<Race> {
    public RaceMap() {
      Table("Races");

      Id(r => r.RaceId);

      Map(r => r.RaceLogicalId);

      References(r => r.FactionRef, "FK_FactionId").Cascade.None().Not.LazyLoad();
    }
  }
}