using AppCode.Infrastructure.Entities;

namespace AppCode.Infrastructure;

public interface IDataContext<TEntity> where TEntity : BaseEntity
{
    public IQueryable<TEntity> Table { get; }

    Task Insert(
        TEntity entity);

    Task Update(
        TEntity entity);
}