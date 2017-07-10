using LootListManager.Logic.Entities.Config;
using System.Collections.Generic;

namespace LootListManager.Logic.DataProviders {
  internal class ConfigDataProvider : DataProvider, IConfigDataProvider {

    #region - NeedType -

    public NeedType GetNeedType(int id) {
      return GetById<NeedType>(id);
    }

    public IList<NeedType> GetNeedTypes() {
      return GetList<NeedType>();
    }

    public NeedType SaveNeedType(NeedType needType) {
      Save(needType);
      return GetById<NeedType>(needType.NeedTypeId);
    }

    public bool DeleteNeedType(int id) {
      var needType = GetNeedType(id);
      Delete(needType);
      return GetById<NeedType>(id) == null;
    }

    #endregion

    #region - Priority -

    public Priority GetPriority(int id) {
      return GetById<Priority>(id);
    }

    public IList<Priority> GetPriorities() {
      return GetList<Priority>();
    }

    public Priority SavePriority(Priority priority) {
      Save(priority);
      return GetById<Priority>(priority.PriorityId);
    }

    public bool DeletePriority(int id) {
      var priority = GetPriority(id);
      Delete(priority);
      return GetById<Priority>(id) == null;
    }

    #endregion

  }
}
