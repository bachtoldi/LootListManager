using LootListManager.Logic.Entities.Player;
using LootListManager.Util;
using System.Globalization;

namespace LootListManager.ViewModels {
  public class RaceViewModel : LinkViewModel {

    #region - Constructor -

    public RaceViewModel(Race race, CultureInfo cultureInfo) {
      RaceId = race.RaceId;
      FactionFk = race.FactionRef.FactionId;
      RaceName = race.RaceName(cultureInfo);
    }

    #endregion

    #region - Properties -

    public int RaceId { get; set; }
    public string RaceName { get; set; }
    public int FactionFk { get; set; }

    #endregion

  }
}