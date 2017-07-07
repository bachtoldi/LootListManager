using LootListManager.Logic.ResourceProviders;
using System.Globalization;

namespace LootListManager.Logic.Entities.Player {
  public class Faction {
    public virtual int FactionId { get; set; }
    public virtual string FactionLogicalId { get; set; }
    public virtual string FactionImage { get; set; }

    public virtual string FactionName(CultureInfo cultureInfo) {
      return ResourceProvider.DatabaseResources.GetResource("FactionNames", FactionLogicalId, cultureInfo);
    }
  }
}