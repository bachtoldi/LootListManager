using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootListManager.Logic.Connectors {
  public static class ConnectorFactory {

    public static IAuthDataConnector GetAuthDataConnector() {
      return new AuthDataConnector();
    }

  }
}
