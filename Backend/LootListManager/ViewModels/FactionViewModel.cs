using LootListManager.Logic.Entities.Player;
using LootListManager.Util;
using System.Globalization;

namespace LootListManager.ViewModels {
  public class FactionViewModel : LinkViewModel {

    #region - Constructor -

    public FactionViewModel(Faction faction, CultureInfo cultureInfo) {
      FactionId = faction.FactionId;
      FactionLogicalId = faction.FactionLogicalId;
      FactionName = faction.FactionName(cultureInfo);
    }

    #endregion

    #region - Properties -

    public int FactionId { get; set; }
    public string FactionLogicalId { get; set; }
    public string FactionName { get; set; }

    #endregion

  }
}