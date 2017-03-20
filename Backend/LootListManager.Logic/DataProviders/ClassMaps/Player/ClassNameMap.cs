using FluentNHibernate.Mapping;
using LootListManager.Logic.Entities.Player;

namespace LootListManager.Logic.DataProviders.ClassMaps.Player {
  public class ClassNameMap : ClassMap<ClassName> {
    public ClassNameMap() {
      Table("ClassNames");

      Id(c => c.ClassNameId);

      Map(c => c.ClassNameCulture);
      Map(c => c.ClassNameString);

      References(c => c.ClassRef, "FK_ClassId");
    }
  }
}