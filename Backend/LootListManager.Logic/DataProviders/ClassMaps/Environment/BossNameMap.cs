using FluentNHibernate.Mapping;
using LootListManager.Logic.Entities.Environment;

namespace LootListManager.Logic.DataProviders.ClassMaps.Environment {
  public class BossNameMap : ClassMap<BossName> {
    public BossNameMap() {
      Table("BossNames");

      Id(b => b.BossNameId);

      Map(b => b.BossNameCulture);
      Map(b => b.BossNameString);

      References(b => b.BossRef, "FK_BossId");
    }
  }
}