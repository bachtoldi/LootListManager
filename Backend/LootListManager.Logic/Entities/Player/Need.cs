using LootListManager.Logic.Entities.Config;
using LootListManager.Logic.Entities.Environment;

namespace LootListManager.Logic.Entities.Player {
  public class Need {
    public virtual int NeedId { get; set; }
    public virtual Character CharacterRef { get; set; }
    public virtual Item ItemRef { get; set; }
    public virtual NeedType NeedTypeRef { get; set; }
    public virtual Priority PriorityRef { get; set; }
  }
}