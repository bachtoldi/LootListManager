using LootListManager.Logic.Entities.Environment;

namespace LootListManager.BindingModels {
  public class InstanceBindingModel {

    #region - Properties -

    public string InstanceLogicalId { get; set; }
    public int InstanceSort { get; set; }

    #endregion

    #region - Public Methods -

    public Instance GetEntity() {
      return new Instance {
        InstanceLogicalId = InstanceLogicalId,
        InstanceSort = InstanceSort
      };
    }

    #endregion

  }
}