using LootListManager.Logic.DataProviders;

namespace LootListManager.Logic.ResourceProviders {
  public static class ResourceProvider {

    private static readonly DatabaseResourceProvider _dbResourceProvider;
    private static string[] _resourceTables;

    static ResourceProvider() {
      InitializeResourceTableArray();
      _dbResourceProvider = new DatabaseResourceProvider(_resourceTables, ConnectionString.String);
    }

    public static DatabaseResourceProvider DatabaseResources {
      get {
        return _dbResourceProvider;
      }
    }

    public static void InitializeResourceTableArray() {
      _resourceTables = new string[] {
        "BossNames",
        "FactionNames",
        "InstanceNames",
        "ItemNames",
        "RaceNames",
        "TalentNames",
      };
    }

  }
}
