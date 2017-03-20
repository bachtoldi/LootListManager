using FluentNHibernate.Mapping;
using LootListManager.Logic.Entities.Player;

namespace LootListManager.Logic.DataProviders.ClassMaps.Player {
  public class RaceMap : ClassMap<Race> {
    public RaceMap() {
      Table("Races");

      Id(r => r.RaceId);

      Map(r => r.RaceImage);

      References(r => r.FactionRef, "FK_FactionId");
    }
  }
}