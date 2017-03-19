using FluentNHibernate.Cfg;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Connection;
using NHibernate.Dialect;
using NHibernate.Driver;

namespace LootListManager.DataProviders {
  public partial class HibernateConfig {

    public static ISessionFactory ConfigureHibernate() {

      Configuration cfg = new Configuration()
        .DataBaseIntegration(db => {
          db.ConnectionProvider<DriverConnectionProvider>();
          db.Driver<SqlClientDriver>();
          db.ConnectionString = "Server=PASCAL-DESKTOP\\SQLEXPRESS; Initial Catalog=LootListManager; Integrated Security=True;";
          db.Dialect<MsSql2012Dialect>();
        });

      var fCfg = Fluently
        .Configure(cfg)
        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Startup>());

      return fCfg.BuildSessionFactory();
    }

  }
}