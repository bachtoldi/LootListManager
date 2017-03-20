namespace LootListManager.Logic.Entities.Player {
  public class RaceName {
    public virtual int RaceNameId { get; set; }
    public virtual Race RaceRef { get; set; }
    public virtual string RaceNameCulture { get; set; }
    public virtual string RaceNameString { get; set; }
  }
}