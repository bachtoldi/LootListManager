using FluentNHibernate.Mapping;
using LootListManager.Logic.Entities.Config;

namespace LootListManager.Logic.DataProviders.ClassMaps.Config {
  public class PriorityMap : ClassMap<Priority> {
    public PriorityMap() {
      Table("Priorities");

      Id(p => p.PriorityId);

      Map(p => p.PriorityName);
    }
  }
}