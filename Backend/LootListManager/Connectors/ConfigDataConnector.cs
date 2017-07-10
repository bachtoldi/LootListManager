using LootListManager.Logic.DataProviders;
using LootListManager.Logic.Entities.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LootListManager.Connectors {
  public class ConfigDataConnector {

    #region - Instance Variables -

    private readonly IConfigDataProvider _dataProvider;

    #endregion

    #region - Constructor -

    public ConfigDataConnector() {
      _dataProvider = DataProviderFactory.GetConfigDataProvider();
    }

    #endregion

    #region - NeedType -

    public NeedType GetNeedType(int id) {
      return _dataProvider.GetNeedType(id);
    }

    public IList<NeedType> GetNeedTypes() {
      return _dataProvider.GetNeedTypes();
    }

    public void SaveNeedType(NeedType needType) {
      _dataProvider.SaveNeedType(needType);
    }

    public void DeleteNeedType(int id) {
      _dataProvider.DeleteNeedType(id);
    }

    #endregion

    #region - Priority -

    public Priority GetPriority(int id) {
      return _dataProvider.GetPriority(id);
    }

    public IList<Priority> GetPriorities() {
      return _dataProvider.GetPriorities();
    }

    public void SavePriority(Priority priority) {
      _dataProvider.SavePriority(priority);
    }

    public void DeletePriority(int id) {
      _dataProvider.DeletePriority(id);
    }

    #endregion

  }
}