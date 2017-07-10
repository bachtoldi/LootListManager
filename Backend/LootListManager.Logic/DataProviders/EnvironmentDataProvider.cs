using LootListManager.Logic.Entities.Environment;
using System.Collections.Generic;
using System.Linq;

namespace LootListManager.Logic.DataProviders {
  internal class EnvironmentDataProvider : DataProvider, IEnvironmentDataProvider {

    #region - Boss -

    public Boss GetBoss(int id) {
      return GetById<Boss>(id);
    }

    public IList<Boss> GetBosses() {
      return GetList<Boss>();
    }

    public IList<Boss> GetBosses(int id) {
      return GetList<Boss>().Where(x => x.BossId == id).ToList();
    }

    public Boss SaveBoss(Boss boss) {
      Save(boss);
      return GetById<Boss>(boss.BossId);
    }

    public bool DeleteBoss(int id) {
      var boss = GetBoss(id);
      Delete(boss);
      return GetById<Boss>(id) == null;
    }

    #endregion

    #region - Instance -

    public Instance GetInstance(int id) {
      return GetById<Instance>(id);
    }

    public IList<Instance> GetInstances() {
      return GetList<Instance>();
    }

    public Instance SaveInstance(Instance instance) {
      Save(instance);
      return GetById<Instance>(instance.InstanceId);
    }

    public bool DeleteInstance(int id) {
      var instance = GetInstance(id);
      Delete(instance);
      return GetById<Instance>(id) == null;
    }

    #endregion

    #region - Item -

    public Item GetItem(int id) {
      return GetById<Item>(id);
    }

    public IList<Item> GetItems() {
      return GetList<Item>();
    }

    public Item SaveItem(Item item) {
      Save(item);
      return GetById<Item>(item.ItemId);
    }

    public bool DeleteItem(int id) {
      var item = GetItem(id);
      Delete(item);
      return GetById<Item>(id) == null;
    }

    #endregion

    #region - ItemBossSetting -

    public ItemBossSetting GetItemBossSetting(int id) {
      return GetById<ItemBossSetting>(id);
    }

    public IList<ItemBossSetting> GetItemBossSettings() {
      return GetList<ItemBossSetting>();
    }

    public ItemBossSetting SaveItemBossSetting(ItemBossSetting itemBossSetting) {
      Save(itemBossSetting);
      return GetById<ItemBossSetting>(itemBossSetting.ItemBossSettingId);
    }

    public bool DeleteItemBossSetting(int id) {
      var itemBossSetting = GetItemBossSetting(id);
      Delete(itemBossSetting);
      return GetById<ItemBossSetting>(id) == null;
    }

    #endregion

  }
}
