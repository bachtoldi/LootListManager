using LootListManager.Logic.ResourceProviders;
using System.Globalization;

namespace LootListManager.Logic.Entities.Environment {
  public class Instance {
    public virtual int InstanceId { get; set; }
    public virtual string InstanceLogicalId { get; set; }
    public virtual int InstanceSort { get; set; }
    public virtual string InstanceImage { get; set; }

    public string InstanceName(CultureInfo cultureInfo) {
      return ResourceProvider.DatabaseResources.GetResource(InstanceLogicalId, cultureInfo);
    }
  }
}