using LootListManager.Logic.ResourceProviders;
using System.Globalization;

namespace LootListManager.Connectors {
  public class ResourceDataConnector {

    #region - Instance Variables -

    private readonly DatabaseResourceProvider _resourceProvider;

    #endregion

    #region - Constructor -

    public ResourceDataConnector() {
      _resourceProvider = ResourceProvider.DatabaseResources;
    }

    #endregion

    #region - Public Methods -

    public void AddResource(ResourceEntry resourceEntry) {
      _resourceProvider.AddResource(resourceEntry);
    }

    public void AddResource(string tableName, string logicalId, string value, CultureInfo cultureInfo) {
      _resourceProvider.AddResource(tableName, logicalId, value, cultureInfo);
    }

    #endregion

  }
}