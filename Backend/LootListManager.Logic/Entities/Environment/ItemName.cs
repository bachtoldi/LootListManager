namespace LootListManager.Logic.Entities.Environment {
  public class ItemName {
    public virtual int ItemNameId { get; set; }
    public virtual Item ItemRef { get; set; }
    public virtual string ItemNameCulture { get; set; }
    public virtual string ItemNameString { get; set; }
  }
}