using LootListManager.Logic.Entities.Player;
using LootListManager.Util;

namespace LootListManager.ViewModels {
  public class FactionViewModel : LinkViewModel {

    #region - Constructor -

    public FactionViewModel(Faction faction) {
      FactionId = faction.FactionId;
      FactionLogicalId = faction.FactionLogicalId;
    }

    #endregion

    #region - Properties -

    public int FactionId { get; set; }
    public string FactionLogicalId { get; set; }

    #endregion

  }
}