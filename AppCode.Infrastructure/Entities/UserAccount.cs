namespace AppCode.Infrastructure.Entities;

public sealed class UserAccount : BaseEntity
{
    public string Name { get; set; }
    
    public string Email { get; set; }
    
    public DateTime CreatedOnUtc { get; set; }
    
    public bool Active { get; set; }
}