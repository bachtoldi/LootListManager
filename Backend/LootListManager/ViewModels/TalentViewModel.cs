using LootListManager.Logic.Entities.Player;
using LootListManager.Util;
using System.Globalization;

namespace LootListManager.ViewModels {
  public class TalentViewModel : LinkViewModel {

    #region - Constructor -

    public TalentViewModel(Talent talent, CultureInfo cultureInfo) {
      TalentId = talent.TalentId;
      TalentLogicalId = talent.TalentLogicalId;
      ClassFk = talent.ClassRef.ClassId;
      TalentName = talent.TalentName(cultureInfo);
    }

    #endregion

    #region - Properties -

    public int TalentId { get; set; }
    public string TalentLogicalId { get; set; }
    public int ClassFk { get; set; }
    public string TalentName { get; set; }

    #endregion

  }
}