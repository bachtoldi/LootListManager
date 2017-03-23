using FluentNHibernate.Cfg;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Connection;
using NHibernate.Dialect;
using NHibernate.Driver;

namespace LootListManager.Logic.DataProviders {
  public partial class HibernateConfig {

    public static ISessionFactory ConfigureHibernate() {

      Configuration cfg = new Configuration()
        .DataBaseIntegration(db => {
          db.ConnectionProvider<DriverConnectionProvider>();
          db.Driver<SqlClientDriver>();
          db.ConnectionString = "Server=" + System.Environment.MachineName + "\\SQLEXPRESS; Initial Catalog=LootListManager; Integrated Security=True;";
          db.Dialect<MsSql2012Dialect>();
        });

      var fCfg = Fluently
        .Configure(cfg)
        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<HibernateConfig>());

      return fCfg.BuildSessionFactory();
    }

  }
}