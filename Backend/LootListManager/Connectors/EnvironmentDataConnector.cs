using LootListManager.Logic.DataProviders;
using LootListManager.Logic.Entities.Environment;
using System.Collections.Generic;

namespace LootListManager.Connectors {
  internal class EnvironmentDataConnector {

    #region - Instance Variables -

    private readonly IEnvironmentDataProvider _dataProvider;

    #endregion

    #region - Constructor -

    public EnvironmentDataConnector() {
      _dataProvider = DataProviderFactory.GetEnvironmentDataProvider();
    }

    #endregion

    #region - Boss -

    public Boss GetBoss(int id) {
      return _dataProvider.GetBoss(id);
    }

    public IList<Boss> GetBosses() {
      return _dataProvider.GetBosses();
    }

    public void SaveBoss(Boss boss) {
      _dataProvider.SaveBoss(boss);
    }

    public void DeleteBoss(int id) {
      _dataProvider.DeleteBoss(id);
    }

    #endregion

    #region - Instance -

    public Instance GetInstance(int id) {
      return _dataProvider.GetInstance(id);
    }

    public IList<Instance> GetInstances() {
      return _dataProvider.GetInstances();
    }

    public void SaveInstance(Instance instance) {
      _dataProvider.SaveInstance(instance);
    }

    public void DeleteInstance(int id) {
      _dataProvider.DeleteInstance(id);
    }

    #endregion

    #region - Item -

    public Item GetItem(int id) {
      return _dataProvider.GetItem(id);
    }

    public IList<Item> GetItems() {
      return _dataProvider.GetItems();
    }

    public void SaveItem(Item item) {
      _dataProvider.SaveItem(item);
    }

    public void DeleteItem(int id) {
      _dataProvider.DeleteItem(id);
    }

    #endregion

    #region - ItemBossSetting -

    public ItemBossSetting GetItemBossSetting(int id) {
      return _dataProvider.GetItemBossSetting(id);
    }

    public IList<ItemBossSetting> GetItemBossSettings() {
      return _dataProvider.GetItemBossSettings();
    }

    public void SaveItemBossSetting(ItemBossSetting itemBossSetting) {
      _dataProvider.SaveItemBossSetting(itemBossSetting);
    }

    public void DeleteItemBossSetting(int id) {
      _dataProvider.DeleteItemBossSetting(id);
    }

    #endregion

  }
}