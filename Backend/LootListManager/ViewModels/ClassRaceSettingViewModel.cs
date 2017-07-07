using LootListManager.Logic.Entities.Player;
using LootListManager.Util;

namespace LootListManager.ViewModels {
  public class ClassRaceSettingViewModel : LinkViewModel {

    #region - Constructor -

    public ClassRaceSettingViewModel(ClassRaceSetting classRaceSetting) {
      ClassRaceSettingId = classRaceSetting.ClassRaceSettingId;
      ClassFk = classRaceSetting.ClassRef.ClassId;
      RaceFk = classRaceSetting.RaceRef.RaceId;
    }

    #endregion

    #region - Properties -

    public int ClassRaceSettingId { get; set; }
    public int ClassFk { get; set; }
    public int RaceFk { get; set; }

    #endregion

  }
}