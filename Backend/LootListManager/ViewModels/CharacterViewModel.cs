using LootListManager.Logic.Entities.Player;
using LootListManager.Util;

namespace LootListManager.ViewModels {
  public class CharacterViewModel : LinkViewModel {

    #region - Constructor -

    public CharacterViewModel(Character character) {
      CharacterId = character.CharacterId;
      CharacterName = character.CharacterName;
      UserFk = character.UserRef.Id;
      RaceFk = character.RaceRef.RaceId;
      TalentFk = character.TalentRef.TalentId;
    }

    #endregion

    #region - Properties -

    public int CharacterId { get; set; }
    public string CharacterName { get; set; }
    public int UserFk { get; set; }
    public int RaceFk { get; set; }
    public int TalentFk { get; set; }

    #endregion

  }
}