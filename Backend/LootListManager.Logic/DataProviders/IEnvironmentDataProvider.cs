using LootListManager.Logic.Entities.Environment;
using System.Collections.Generic;

namespace LootListManager.Logic.DataProviders {
  public interface IEnvironmentDataProvider {

    #region - Boss -

    Boss GetBoss(int id);
    IList<Boss> GetBosses();
    IList<Boss> GetBosses(int instanceId);
    Boss SaveBoss(Boss boss);
    bool DeleteBoss(int id);

    #endregion

    #region - BossName -

    BossName GetBossName(int id);
    BossName GetBossName(int bossId, string culture);
    IList<BossName> GetBossNames();
    IList<BossName> GetBossNames(int instanceId, string culture);
    BossName SaveBossName(BossName bossName);
    bool DeleteBossName(int id);

    #endregion

    #region - Instance -

    Instance GetInstance(int id);
    IList<Instance> GetInstances();
    Instance SaveInstance(Instance instance);
    bool DeleteInstance(int id);

    #endregion

    #region - InstanceName -

    InstanceName GetInstanceName(int id);
    InstanceName GetInstanceName(int instanceId, string culture);
    IList<InstanceName> GetInstanceNames();
    InstanceName SaveInstanceName(InstanceName instanceName);
    bool DeleteInstanceName(int id);

    #endregion

    #region - Item -

    #endregion

    #region - ItemName -

    #endregion

    #region - ItemBossSetting -

    #endregion

  }
}
