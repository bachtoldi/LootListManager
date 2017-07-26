using LootListManager.Logic.Entities.Player;
using LootListManager.Util;

namespace LootListManager.ViewModels {
  public class RaceViewModel : LinkViewModel {

    #region - Constructor -

    public RaceViewModel(Race race) {
      RaceId = race.RaceId;
      RaceLogicalId = race.RaceLogicalId;
      FactionFk = race.FactionRef.FactionId;
    }

    #endregion

    #region - Properties -

    public int RaceId { get; set; }
    public string RaceLogicalId { get; set; }
    public int FactionFk { get; set; }

    #endregion

  }
}