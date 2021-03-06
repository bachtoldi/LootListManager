﻿using NHibernate;

namespace LootListManager.Logic.DataProviders {
  public static class SessionFactory {

    static SessionFactory() {
      _sessionFactory = HibernateConfig.ConfigureHibernate();
    }

    private static ISessionFactory _sessionFactory;

    public static ISession Session {
      get {
        return _sessionFactory.OpenSession();
      }
    }

  }
}