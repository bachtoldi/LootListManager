using FluentNHibernate.Mapping;
using LootListManager.Logic.Entities.Player;

namespace LootListManager.Logic.DataProviders.ClassMaps.Player {
  public class FactionNameMap : ClassMap<FactionName> {
    public FactionNameMap() {
      Table("FactionNames");

      Id(f => f.FactionNameId);

      Map(f => f.FactionNameCulture);
      Map(f => f.FactionNameString);

      References(f => f.FactionRef, "FK_FactionId");
    }
  }
}