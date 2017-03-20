namespace LootListManager.Logic.Entities.Player {
  public class TalentName {
    public virtual int TalentNameId { get; set; }
    public virtual Talent TalentRef { get; set; }
    public virtual string TalentNameCulture { get; set; }
    public virtual string TalentNameString { get; set; }
  }
}