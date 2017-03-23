using LootListManager.Logic.Entities.Environment;
using System.Collections.Generic;
using System.Globalization;

namespace LootListManager.Logic.DataProviders {
  internal class EnvironmentDataProvider : DataProvider, IEnvironmentDataProvider {

    #region - Boss -

    public Boss GetBoss(int id) {
      return null;
    }

    public IList<Boss> GetBosses() {
      return null;
    }

    public IList<Boss> GetBosses(int instanceId) {
      return null;
    }

    public Boss SaveBoss(Boss boss) {
      return null;
    }

    public bool DeleteBoss(int id) {
      return false;
    }

    #endregion

    #region - Instance -

    public Instance GetInstance(int id) {
      return null;
    }

    public IList<Instance> GetInstances() {
      return null;
    }

    public Instance SaveInstance(Instance instance) {
      return null;
    }

    public bool DeleteInstance(int id) {
      return false;
    }

    #endregion

    #region - Item -

    #endregion

    #region - ItemBossSetting -

    #endregion

  }
}
