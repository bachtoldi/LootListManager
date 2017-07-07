using LootListManager.Logic.ResourceProviders;
using System.Globalization;

namespace LootListManager.Logic.Entities.Player {
  public class Class {
    public virtual int ClassId { get; set; }
    public virtual string ClassLogicalId { get; set; }
    public virtual string ClassImage { get; set; }

    public virtual string ClassName(CultureInfo cultureInfo) {
      return ResourceProvider.DatabaseResources.GetResource("ClassNames", ClassLogicalId, cultureInfo);
    }
  }
}