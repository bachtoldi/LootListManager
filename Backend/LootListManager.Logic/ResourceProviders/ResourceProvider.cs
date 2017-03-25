using LootListManager.Logic.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootListManager.Logic.ResourceProviders {
  public static class ResourceProvider {

    private static readonly DatabaseResourceProvider _dbResourceProvider;

    static ResourceProvider() {
      var supportetCultures = new string[] { "de", "en" };
      _dbResourceProvider = new DatabaseResourceProvider(supportetCultures, ConnectionString.String);
    }

    public static DatabaseResourceProvider DatabaseResources {
      get {
        return _dbResourceProvider;
      }
    }

  }
}
