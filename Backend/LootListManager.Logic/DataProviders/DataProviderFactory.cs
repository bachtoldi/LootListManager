using System.Globalization;

namespace LootListManager.Logic.DataProviders {
  public static class DataProviderFactory {

    public static IAuthDataProvider GetAuthDataProvider() {
      return new AuthDataProvider();
    }

    public static IEnvironmentDataProvider GetEnvironmentDataProvider() {
      return new EnvironmentDataProvider();
    }

    public static IPlayerDataProvider GetPlayerDataProvider() {
      return new PlayerDataProvider();
    }

  }
}
