using FluentNHibernate.Mapping;
using LootListManager.Logic.Entities.Environment;

namespace LootListManager.Logic.DataProviders.ClassMaps.Environment {
  public class InstanceMap:ClassMap<Instance> {
    public InstanceMap() {
      Table("Instances");

      Id(i => i.InstanceId);

      Map(i => i.InstanceSort);
      Map(i => i.InstanceImage);
    }
  }
}