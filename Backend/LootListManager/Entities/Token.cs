using System;

namespace LootListManager.Entities {
  public class Token {
    public virtual int TokenId { get; set; }
    public virtual User UserRef { get; set; }
    public virtual string AuthToken { get; set; }
    public virtual DateTime IssuedOn { get; set; }
    public virtual DateTime ExpiresOn { get; set; }
  }
}