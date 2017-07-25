using LootListManager.Logic.Entities.Player;
using LootListManager.Util;

namespace LootListManager.ViewModels {
  public class TalentViewModel : LinkViewModel {

    #region - Constructor -

    public TalentViewModel(Talent talent) {
      TalentId = talent.TalentId;
      TalentLogicalId = talent.TalentLogicalId;
      ClassFk = talent.ClassRef.ClassId;
    }

    #endregion

    #region - Properties -

    public int TalentId { get; set; }
    public string TalentLogicalId { get; set; }
    public int ClassFk { get; set; }

    #endregion

  }
}