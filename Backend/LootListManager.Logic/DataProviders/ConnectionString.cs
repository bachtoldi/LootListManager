using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootListManager.Logic.DataProviders {
  public static class ConnectionString {
    public static string String = "Server=" + System.Environment.MachineName + "\\SQLEXPRESS; Initial Catalog=LootListManager; Integrated Security=True;";
  }
}
