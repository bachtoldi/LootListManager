using LootListManager.Logic.Entities.Player;
using FluentNHibernate.Mapping;

namespace LootListManager.Logic.DataProviders.ClassMaps.Player {
  public class ClassMap : ClassMap<Class> {
    public ClassMap() {
      Table("Classes");

      Id(c => c.ClassId);

      Map(c => c.ClassImage);
    }
  }
}