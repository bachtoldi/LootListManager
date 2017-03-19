using LootListManager.Entities;
using System.Collections.Generic;
using System.Linq;

namespace LootListManager.DataProviders {
  public class DataProvider {

    #region - User -

    public User GetUser(int id) {
      return GetById<User>(id);
    }

    public IList<User> GetUsers() {
      return GetList<User>();
    }

    public User SaveUser(User user) {
      Save<User>(user);
      return GetById<User>(user.UserId);
    }

    public bool DeleteUser(User user) {
      Delete<User>(user);
      return GetById<User>(user.UserId) == null;
    }

    #endregion

    #region - Private Methods -

    private T GetById<T>(int id) where T : class {
      var session = SessionFactory.Session;

      using(var transaction = session.BeginTransaction()) {
        var entity = session.Get<T>(id);
        transaction.Commit();
        session.Close();
        return entity;
      }
    }

    private IList<T> GetList<T>() where T : class {
      var session = SessionFactory.Session;

      using(var transaction = session.BeginTransaction()) {
        var list = session.QueryOver<T>().List().ToList();
        transaction.Commit();
        session.Close();
        return list;
      }
    }

    private void Save<T>(T entity) where T : class {
      var session = SessionFactory.Session;

      using(var transaction = session.BeginTransaction()) {
        session.SaveOrUpdate(entity);
        transaction.Commit();
        session.Close();
      }
    }

    private void Delete<T>(T entity) where T : class {
      var session = SessionFactory.Session;

      using(var transaction = session.BeginTransaction()) {
        session.Delete(entity);
        transaction.Commit();
        session.Close();
      }
    }

    #endregion

  }
}