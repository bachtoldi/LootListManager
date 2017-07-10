using LootListManager.Logic.ResourceProviders;
using System.Globalization;

namespace LootListManager.Logic.Entities.Player {
  public class Race {
    public virtual int RaceId { get; set; }
    public virtual string RaceLogicalId { get; set; }
    public virtual Faction FactionRef { get; set; }
    public virtual string RaceImage { get; set; }

    public virtual string RaceName(CultureInfo cultureInfo) {
      return ResourceProvider.DatabaseResources.GetResource("RaceNames", RaceLogicalId, cultureInfo);
    }
  }
}