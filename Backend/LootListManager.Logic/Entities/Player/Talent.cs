using LootListManager.Logic.ResourceProviders;
using System.Globalization;

namespace LootListManager.Logic.Entities.Player {
  public class Talent {
    public virtual int TalentId { get; set; }
    public virtual string TalentLogicalId { get; set; }
    public virtual Class ClassRef { get; set; }
    public virtual string TalentImage { get; set; }

    public virtual string TalentName(CultureInfo cultureInfo) {
      return ResourceProvider.DatabaseResources.GetResource("TalentNames", TalentLogicalId, cultureInfo);
    }
  }
}