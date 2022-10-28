using AppCode.Infrastructure.Entities;
using LinqToDB;
using LinqToDB.DataProvider.SqlServer;

namespace AppCode.Infrastructure;

public sealed class MsSqlServerDataProvider : IDataProvider
{
    private static readonly Lazy<IDataProvider> _dataProvider = new (
        () => new MsSqlServerDataProvider(), 
        true);
    
    public IQueryable<TEntity> GetTable<TEntity>()
        where TEntity : BaseEntity
    {
        throw new NotImplementedException();
    }
}