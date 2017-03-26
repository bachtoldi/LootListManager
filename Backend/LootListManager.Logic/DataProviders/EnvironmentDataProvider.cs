using LootListManager.Logic.Entities.Environment;
using System.Collections.Generic;

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
      return GetById<Instance>(instance.InstanceId) == null;
    }

    #endregion

    #region - Item -

    #endregion

    #region - ItemBossSetting -

    #endregion

  }
}
