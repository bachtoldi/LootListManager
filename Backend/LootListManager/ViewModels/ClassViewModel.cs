using LootListManager.Logic.Entities.Player;
using LootListManager.Util;

namespace LootListManager.ViewModels {
  public class ClassViewModel : LinkViewModel {

    #region - Constructor -

    public ClassViewModel(Class c) {
      ClassId = c.ClassId;
      ClassLogicalId = c.ClassLogicalId;
    }

    #endregion

    #region - Properties -

    public int ClassId { get; set; }
    public string ClassLogicalId { get; set; }

    #endregion

  }
}