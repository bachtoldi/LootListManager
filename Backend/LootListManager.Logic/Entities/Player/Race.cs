namespace LootListManager.Logic.Entities.Player {
  public class Race {
    public virtual int RaceId { get; set; }
    public virtual string RaceLogicalId { get; set; }
    public virtual Faction FactionRef { get; set; }
  }
}