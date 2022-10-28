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
    public IQueryable<TEntity> Table => _dataProvider.GetTable<TEntity>();
}