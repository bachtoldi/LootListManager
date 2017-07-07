using LootListManager.Logic.Entities.Player;

namespace LootListManager.BindingModels {
  public class FactionBindingModel {

    #region - Properties -

    public string FactionLogicalId { get; set; }

    #endregion

    #region - Public Methods -

    public Faction GetEntity() {
      return new Faction {
        FactionLogicalId = FactionLogicalId,
      };
    }

    #endregion

  }
}