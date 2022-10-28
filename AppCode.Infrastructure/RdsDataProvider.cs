using AppCode.Infrastructure.Entities;
using LinqToDB;
using LinqToDB.Configuration;
using LinqToDB.Data;
using LinqToDB.Mapping;

namespace AppCode.Infrastructure;

public sealed class RdsDataProvider : IDataProvider
{
    private readonly LinqToDBConnectionOptions _config;
    private readonly MappingSchema _mappingSchema;

    public RdsDataProvider(
        LinqToDBConnectionOptions config,
        MappingSchema mappingSchema)
    {
        _config = config;
        _mappingSchema = mappingSchema;
    }

    public IQueryable<TEntity> Query<TEntity>()
        where TEntity : BaseEntity
    {
        return new LinqToDB.DataContext(_config)
        {
            MappingSchema = _mappingSchema
        }.GetTable<TEntity>();
    }

    public async Task<TEntity> InsertEntity<TEntity>(
        TEntity entity)
        where TEntity : BaseEntity
    {
        using var dataContext = CreateDataConnection();
        entity.Id = await dataContext.InsertWithInt32IdentityAsync(entity);
        return entity;
    }
    
    public async Task UpdateEntity<TEntity>(TEntity entity) where TEntity : BaseEntity
    {
        using var dataContext = CreateDataConnection();
        await dataContext.UpdateAsync(entity);
    }

    private DataConnection CreateDataConnection()
    {
        return new LinqToDB.Data.DataConnection(_config);
    }
}