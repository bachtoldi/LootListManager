using FluentNHibernate.Mapping;
using LootListManager.Logic.Entities.Environment;

namespace LootListManager.Logic.DataProviders.ClassMaps.Environment {
  public class BossMap : ClassMap<Boss> {
    public BossMap() {
      Table("Bosses");

      Id(b => b.BossId);

      Map(b => b.BossSort);

      References(b => b.InstanceRef, "FK_InstanceId").Cascade.None();
    }
  }
}