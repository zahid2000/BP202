﻿namespace Core.DataAccess.Abstract;

public interface IEntityRepository<TEntity>
    where TEntity : class,IEntity, new()
{
    Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> exp = null, params string[] includes);
    Task<List<TEntity>> GetAllPaginatedAsync(int page, int size, Expression<Func<TEntity, bool>> exp = null, params string[] includes);
    Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> exp, params string[] includes);
    Task<bool> IsExistsAsync(Expression<Func<TEntity, bool>> exp);
    Task CreateAsync(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    Task<int> SaveAsync();

}

