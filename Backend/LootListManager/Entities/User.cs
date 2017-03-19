namespace LootListManager.Entities {
  public class User {
    public virtual int UserId { get; set; }
    public virtual string UserName { get; set; }
    public virtual string UserPasswordHash { get; set; }
    public virtual int UserLoginAttempts { get; set; }
  }
}