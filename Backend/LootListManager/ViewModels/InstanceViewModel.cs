using LootListManager.Logic.Entities.Environment;
using LootListManager.Util;
using System.Globalization;

namespace LootListManager.ViewModels {
  public class InstanceViewModel : LinkViewModel {

    #region - Constructor -

    public InstanceViewModel(Instance instance, CultureInfo cultureInfo) {
      InstanceId = instance.InstanceId;
      InstanceSort = instance.InstanceSort;
      InstanceName = instance.InstanceName(cultureInfo);
    }

    #endregion

    #region - Properties -

    public int InstanceId { get; set; }
    public string InstanceLogicalId { get; set; }
    public int InstanceSort { get; set; }
    public string InstanceName { get; set; }

    #endregion

  }
}