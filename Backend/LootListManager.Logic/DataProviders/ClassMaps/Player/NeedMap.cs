using FluentNHibernate.Mapping;
using LootListManager.Logic.Entities.Player;

namespace LootListManager.Logic.DataProviders.ClassMaps.Player {
  public class NeedMap : ClassMap<Need> {
    public NeedMap() {
      Table("Needs");

      Id(n => n.NeedId);

      References(c => c.CharacterRef, "FK_CharacterId");
      References(c => c.ItemRef, "FK_ItemId");
      References(c => c.NeedTypeRef, "FK_NeedTypeId");
      References(c => c.PriorityRef, "FK_PriorityId");
    }
  }
}