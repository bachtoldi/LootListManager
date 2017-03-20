namespace LootListManager.Entities.Environment {
    public class Boss {
        public virtual int BossId { get; set; }
        public virtual int BossSort { get; set; }
        public virtual Instance InstanceRef { get; set; }
    }
}