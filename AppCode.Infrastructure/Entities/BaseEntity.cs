namespace AppCode.Infrastructure.Entities;

public abstract class BaseEntity
{
    public int Id { get; set; }
    
    public Guid Guid { get; set; }
}