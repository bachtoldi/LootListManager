namespace LootListManager.Logic.Entities.Auth {
  public class User {
    public virtual int Id { get; set; }
    public virtual string UserName { get; set; }
    public virtual string PasswordHash { get; set; }
    public virtual int UserLoginAttempts { get; set; }
  }
}