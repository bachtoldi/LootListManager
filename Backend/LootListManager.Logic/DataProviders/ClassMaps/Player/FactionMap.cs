using FluentNHibernate.Mapping;
using LootListManager.Logic.Entities.Player;

namespace LootListManager.Logic.DataProviders.ClassMaps.Player {
  public class FactionMap : ClassMap<Faction> {
    public FactionMap() {
      Table("Factions");

      Id(f => f.FactionId);

      Map(f => f.FactionImage);
    }
  }
}