using LootListManager.Entities.Auth;

namespace LootListManager.Entities.Player {
    public class Character {
        public virtual int CharacterId { get; set; }
        public virtual string CharacterName { get; set; }
        public virtual User UserRef { get; set; }
        public virtual Race RaceRef { get; set; }
        public virtual Talent TalentRef { get; set; }
    }
}