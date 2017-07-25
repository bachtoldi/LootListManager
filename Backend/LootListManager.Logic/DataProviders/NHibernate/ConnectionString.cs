namespace LootListManager.Logic.DataProviders {
  public static class ConnectionString {
    public static string String = "Server=" + GetServerName() + "; Initial Catalog=LootListManager; Integrated Security=True;";

    public static string GetServerName() {
      if (System.Environment.MachineName.Equals("WIGAWORK56")) {
        return System.Environment.MachineName;
      } else {
        return System.Environment.MachineName + "\\SQLEXPRESS";
      }

    }
  }
}
