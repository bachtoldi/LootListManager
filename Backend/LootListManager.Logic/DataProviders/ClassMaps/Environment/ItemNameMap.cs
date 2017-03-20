using FluentNHibernate.Mapping;
using LootListManager.Logic.Entities.Environment;

namespace LootListManager.Logic.DataProviders.ClassMaps.Environment {
  public class ItemNameMap : ClassMap<ItemName> {
    public ItemNameMap() {
      Table("ItemNames");

      Id(i => i.ItemNameId);

      Map(i => i.ItemNameCulture);
      Map(i => i.ItemNameString);

      References(i => i.ItemRef, "FK_ItemId");
    }
  }
}