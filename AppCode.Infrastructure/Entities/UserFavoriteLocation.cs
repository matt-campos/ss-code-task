namespace AppCode.Infrastructure.Entities;

internal sealed class UserFavoriteLocation : BaseEntity
{
    public int Id { get; set; }
    
    public Guid Guid { get; set; }
    
    public int UserAccountId { get; set; }
    
    public string City { get; set; }
    
    public string Country { get; set; }
    
    public DateTime CreatedOnUtc { get; set; }
}