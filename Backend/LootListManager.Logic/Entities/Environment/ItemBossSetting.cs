namespace LootListManager.Logic.Entities.Environment {
  public class ItemBossSetting {
    public virtual int ItemBossSettingId { get; set; }
    public virtual Item ItemRef { get; set; }
    public virtual Boss BossRef { get; set; }
  }
}