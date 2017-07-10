using LootListManager.Logic.Entities.Config;
using System.Collections.Generic;

namespace LootListManager.Logic.DataProviders {
  public interface IConfigDataProvider {

    #region - NeedType -

    NeedType GetNeedType(int id);
    IList<NeedType> GetNeedTypes();
    NeedType SaveNeedType(NeedType needType);
    bool DeleteNeedType(int id);

    #endregion

    #region - Priority -

    Priority GetPriority(int id);
    IList<Priority> GetPriorities();
    Priority SavePriority(Priority priority);
    bool DeletePriority(int id);

    #endregion

  }
}
