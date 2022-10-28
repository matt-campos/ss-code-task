namespace AppCode.Infrastructure.Entities;

public abstract class BaseEntity
{
    public int Id { get; }
    
    public Guid Guid { get; set; }
}