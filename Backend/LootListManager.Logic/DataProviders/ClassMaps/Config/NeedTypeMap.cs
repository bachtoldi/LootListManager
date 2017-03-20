using FluentNHibernate.Mapping;
using LootListManager.Logic.Entities.Config;

namespace LootListManager.Logic.DataProviders.ClassMaps.Config {
  public class NeedTypeMap : ClassMap<NeedType> {
    public NeedTypeMap() {
      Table("NeedTypes");

      Id(n => n.NeedTypeId);

      Map(n => n.NeedTypeName);
    }
  }
}