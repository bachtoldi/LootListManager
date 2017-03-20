namespace LootListManager.Logic.Entities.Environment {
    public class BossName {
        public virtual int BossNameId { get; set; }
        public virtual Boss BossRef { get; set; }
        public virtual string BossNameCulture { get; set; }
        public virtual string BossNameString { get; set; }
    }
}