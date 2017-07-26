using FluentNHibernate.Mapping;
using LootListManager.Logic.Entities.Environment;

namespace LootListManager.Logic.DataProviders.ClassMaps.Environment {
  public class ItemMap:ClassMap<Item> {
    public ItemMap() {
      Table("Items");

      Id(i => i.ItemId);
    }
  }
}