namespace AppCode.Infrastructure.Entities;

public sealed class UserPassword : BaseEntity
{
    public int UserAccountId { get; set; }
    
    public string Password { get; set; }
    
    public string Salt { get; set; }
    
    public DateTime CreatedOnUtc { get; set; }
}