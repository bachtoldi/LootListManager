using FluentNHibernate.Mapping;
using LootListManager.Logic.Entities.Player;

namespace LootListManager.Logic.DataProviders.ClassMaps.Player {
  public class ClassRaceSettingMap : ClassMap<ClassRaceSetting> {
    public ClassRaceSettingMap() {
      Table("ClassRaceSettings");

      Id(c => c.ClassRaceSettingId);

      References(c => c.ClassRef, "FK_ClassId").Cascade.None();
      References(c => c.RaceRef, "FK_RaceId").Cascade.None();
    }
  }
}