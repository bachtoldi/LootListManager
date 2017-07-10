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

    #endregion

    #region - ItemBossSetting -

    #endregion

  }
}