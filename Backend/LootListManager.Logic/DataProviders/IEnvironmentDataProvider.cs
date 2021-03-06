﻿using LootListManager.Logic.Entities.Environment;
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

    #region - Instance -

    Instance GetInstance(int id);
    IList<Instance> GetInstances();
    Instance SaveInstance(Instance instance);
    bool DeleteInstance(int id);

    #endregion

    #region - Item -

    #endregion

    #region - ItemBossSetting -

    #endregion

  }
}
