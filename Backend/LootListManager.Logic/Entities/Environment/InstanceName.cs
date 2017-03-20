namespace LootListManager.Logic.Entities.Environment {
  public class InstanceName {
    public virtual int InstanceNameId { get; set; }
    public virtual Instance InstanceRef { get; set; }
    public virtual string InstanceNameCulture { get; set; }
    public virtual string InstanceNameString { get; set; }
  }
}