using FluentNHibernate.Mapping;
using LootListManager.Logic.Entities.Environment;

namespace LootListManager.Logic.DataProviders.ClassMaps.Environment {
  public class InstanceNameMap : ClassMap<InstanceName> {
    public InstanceNameMap() {
      Table("InstanceNames");

      Id(i => i.InstanceNameId);

      Map(i => i.InstanceNameCulture);
      Map(i => i.InstanceNameString);

      References(i => i.InstanceRef, "FK_InstanceId");
    }
  }
}