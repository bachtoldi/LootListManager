using LootListManager.Logic.Entities.Player;

namespace LootListManager.BindingModels {
  public class ClassBindingModel {

    #region - Properties -

    public string ClassLogicalId { get; set; }


    #endregion

    #region - Public Methods -

    public Class GetEntity() {
      return new Class {
        ClassLogicalId = ClassLogicalId,
      };
    }

    #endregion

  }
}