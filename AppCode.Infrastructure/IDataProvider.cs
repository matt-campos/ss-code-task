using AppCode.Infrastructure.Entities;

namespace AppCode.Infrastructure;

public interface IDataProvider
{
    /// <summary>
    /// Returns queryable 
    /// </summary>
    IQueryable<TEntity> Query<TEntity>() 
        where TEntity : BaseEntity;

    Task<TEntity> InsertEntity<TEntity>(
        TEntity entity)
        where TEntity : BaseEntity;

    Task UpdateEntity<TEntity>(
        TEntity entity)
        where TEntity : BaseEntity;
}