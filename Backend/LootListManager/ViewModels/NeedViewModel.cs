using LootListManager.Logic.Entities.Player;
using LootListManager.Util;

namespace LootListManager.ViewModels {
  public class NeedViewModel : LinkViewModel {

    #region - Constructor -

    public NeedViewModel(Need need) {
      NeedId = need.NeedId;
      CharacterFk = need.CharacterRef.CharacterId;
      ItemFk = need.ItemRef.ItemId;
      NeedTypeFk = need.NeedTypeRef.NeedTypeId;
      PriortyFk = need.PriorityRef.PriorityId;
    }

    #endregion

    #region - Properties -

    public int NeedId { get; set; }
    public int CharacterFk { get; set; }
    public int ItemFk { get; set; }
    public int NeedTypeFk { get; set; }
    public int PriortyFk { get; set; }

    #endregion

  }
}