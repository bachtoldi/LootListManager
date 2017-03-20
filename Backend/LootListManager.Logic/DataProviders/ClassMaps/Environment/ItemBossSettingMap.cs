using FluentNHibernate.Mapping;
using LootListManager.Logic.Entities.Environment;

namespace LootListManager.Logic.DataProviders.ClassMaps.Environment {
  public class ItemBossSettingMap : ClassMap<ItemBossSetting> {
    public ItemBossSettingMap() {
      Table("ItemBossSettings");

      Id(i => i.ItemBossSettingId);

      References(i => i.ItemRef, "FK_ItemId");
      References(i => i.BossRef, "FK_BossId");
    }
  }
}