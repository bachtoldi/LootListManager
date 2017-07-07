using LootListManager.Logic.ResourceProviders;

namespace LootListManager.BindingModels {
  public class ResourceEntryBindingModel {

    #region - Properties -

    public string ResourceLogicalId { get; set; }
    public string ResourceCulture { get; set; }
    public string ResourceValue { get; set; }

    #endregion

    #region - Public Methods -

    public ResourceEntry GetResourceEntry(string entity) {
      return new ResourceEntry {
        TableName = entity + "Names",
        LogicalId = ResourceLogicalId,
        Culture = ResourceCulture,
        Value = ResourceValue,
      };
    }

    #endregion

  }
}