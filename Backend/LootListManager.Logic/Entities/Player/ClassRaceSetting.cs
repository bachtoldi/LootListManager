namespace LootListManager.Logic.Entities.Player {
  public class ClassRaceSetting {
    public virtual int ClassRaceSettingId { get; set; }
    public virtual Class ClassRef { get; set; }
    public virtual Race RaceRef { get; set; }
  }
}