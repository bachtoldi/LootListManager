using LootListManager.Logic.Entities.Player;
using LootListManager.Util;
using System.Globalization;

namespace LootListManager.ViewModels {
  public class ClassViewModel : LinkViewModel {

    #region - Constructor -

    public ClassViewModel(Class c, CultureInfo cultureInfo) {
      ClassId = c.ClassId;
      ClassLogicalId = c.ClassLogicalId;
      ClassName = c.ClassName(cultureInfo);
    }

    #endregion

    #region - Properties -

    public int ClassId { get; set; }
    public string ClassLogicalId { get; set; }
    public string ClassName { get; set; }

    #endregion

  }
}