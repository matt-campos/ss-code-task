using AppCode.Infrastructure.Entities;

namespace AppCode.Infrastructure;

public sealed class DataContext<TEntity> : IDataContext<TEntity>
    where TEntity : BaseEntity
{
    private readonly IDataProvider _dataProvider;

    public DataContext(
        IDataProvider dataProvider)
    {
        _dataProvider = dataProvider;
    }

    /// <summary>
    /// Gets a table
    /// </summary>
    public IQueryable<TEntity> Table => _dataProvider.Query<TEntity>();
    
    /// <summary>
    /// Insert the entity entry
    /// </summary>
    public async Task Insert(TEntity entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity));
        }
        
        await _dataProvider.InsertEntity(entity);
    }
    
    public async Task Update(TEntity entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity));
        }
        
        await _dataProvider.UpdateEntity(entity);
    }
}