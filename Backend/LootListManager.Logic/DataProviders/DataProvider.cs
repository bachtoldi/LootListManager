using System;
using System.Collections.Generic;
using System.Linq;

namespace LootListManager.Logic.DataProviders {
  internal class DataProvider {
    
    internal T GetById<T>(int id) where T : class {
      var session = SessionFactory.Session;

      using(var transaction = session.BeginTransaction()) {
        var entity = session.Get<T>(id);
        transaction.Commit();
        session.Close();
        return entity;
      }
    }

    internal IList<T> GetList<T>() where T : class {
      var session = SessionFactory.Session;

      try {
        using (var transaction = session.BeginTransaction()) {
          var list = session.QueryOver<T>().List().ToList();
          transaction.Commit();
          session.Close();
          return list;
        }
      } catch (Exception ex) {
        throw ex;
      }
    }

    internal void Save<T>(T entity) where T : class {
      var session = SessionFactory.Session;

      using(var transaction = session.BeginTransaction()) {
        session.SaveOrUpdate(entity);
        transaction.Commit();
        session.Close();
      }
    }

    internal void Delete<T>(T entity) where T : class {
      var session = SessionFactory.Session;

      using(var transaction = session.BeginTransaction()) {
        session.Delete(entity);
        transaction.Commit();
        session.Close();
      }
    }
    
  }
}