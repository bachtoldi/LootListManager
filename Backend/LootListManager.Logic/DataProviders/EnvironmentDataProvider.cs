using LootListManager.Logic.Entities.Environment;
using System.Collections.Generic;

namespace LootListManager.Logic.DataProviders {
  internal class EnvironmentDataProvider : DataProvider, IEnvironmentDataProvider {

    #region - Boss -

    public Boss GetBoss(int id) {

    }

    public IList<Boss> GetBosses() {

    }

    public IList<Boss> GetBosses(int instanceId) {

    }

    public Boss SaveBoss(Boss boss) {

    }

    public bool DeleteBoss(int id) {

    }

    #endregion

    #region - BossName -

    public BossName GetBossName(int id) {

    }

    public BossName GetBossName(int bossId, string culture) {

    }

    public IList<BossName> GetBossNames() {

    }

    public IList<BossName> GetBossNames(int instanceId, string culture) {

    }

    public BossName SaveBossName(BossName bossName) {

    }

    public bool DeleteBossName(int id) {

    }

    #endregion

    #region - Instance -

    public Instance GetInstance(int id) {

    }

    public IList<Instance> GetInstances() {

    }

    public Instance SaveInstance(Instance instance) {

    }

    public bool DeleteInstance(int id) {

    }

    #endregion

    #region - InstanceName -

    public InstanceName GetInstanceName(int id) {

    }

    public InstanceName GetInstanceName(int instanceId, string culture) {

    }

    public IList<InstanceName> GetInstanceNames() {

    }

    public InstanceName SaveInstanceName(InstanceName instanceName) {

    }

    public bool DeleteInstanceName(int id) {

    }

    #endregion

    #region - Item -

    #endregion

    #region - ItemName -

    #endregion

    #region - ItemBossSetting -

    #endregion

  }
}
