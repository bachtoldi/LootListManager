using LootListManager.Logic.Entities.Environment;
using LootListManager.Util;

namespace LootListManager.ViewModels {
  public class InstanceViewModel : LinkViewModel {

    #region - Constructor -

    public InstanceViewModel(Instance instance) {
      InstanceId = instance.InstanceId;
      InstanceSort = instance.InstanceSort;
    }

    #endregion

    #region - Properties -

    public int InstanceId { get; set; }
    public string InstanceLogicalId { get; set; }
    public int InstanceSort { get; set; }

    #endregion

  }
}