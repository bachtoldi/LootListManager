using Microsoft.Practices.Unity;

namespace LootListManager {
  public class UnityRegistration {

    #region - Container -

    private static UnityContainer _container;
    public static UnityContainer Container {
      get {
        if(_container == null) {
          new UnityRegistration();
        }

        return _container;
      }
    }

    #endregion

    #region - Constructor -

    public UnityRegistration() {
      _container = new UnityContainer();
    }

    #endregion

  }
}