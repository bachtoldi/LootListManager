using FluentNHibernate.Mapping;
using LootListManager.Logic.Entities.Player;

namespace LootListManager.Logic.DataProviders.ClassMaps.Player {
  public class RaceNameMap : ClassMap<RaceName> {
    public RaceNameMap() {
      Table("RaceNames");

      Id(r => r.RaceNameId);

      Map(r => r.RaceNameCulture);
      Map(r => r.RaceNameString);

      References(r => r.RaceRef, "FK_RaceId");
    }
  }
}