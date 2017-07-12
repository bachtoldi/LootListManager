using FluentNHibernate.Mapping;
using LootListManager.Logic.Entities.Player;

namespace LootListManager.Logic.DataProviders.ClassMaps.Player {
  public class NeedMap : ClassMap<Need> {
    public NeedMap() {
      Table("Needs");

      Id(n => n.NeedId);

      References(c => c.CharacterRef, "FK_CharacterId").Cascade.None();
      References(c => c.ItemRef, "FK_ItemId").Cascade.None();
      References(c => c.NeedTypeRef, "FK_NeedTypeId").Cascade.None();
      References(c => c.PriorityRef, "FK_PriorityId").Cascade.None();
    }
  }
}