using AppCode.Infrastructure.Entities;

namespace AppCode.Infrastructure;

public interface IDataProvider
{
    /// <summary>
    /// Returns queryable 
    /// </summary>
    IQueryable<TEntity> GetTable<TEntity>() where TEntity : BaseEntity;
}