namespace LootListManager.Logic.Entities.Player {
  public class FactionName {
    public virtual int FactionNameId { get; set; }
    public virtual Faction FactionRef { get; set; }
    public virtual string FactionNameCulture { get; set; }
    public virtual string FactionNameString { get; set; }
  }
}