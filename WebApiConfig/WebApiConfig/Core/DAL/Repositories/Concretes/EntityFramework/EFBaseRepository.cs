using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebApiConfig.Core.DAL.Repositories.Abstracts;
using WebApiConfig.DAL;
using WebApiConfig.Entities;

namespace WebApiConfig.Core.DAL.Repositories.Concretes.EntityFramework
{
    public class EFBaseRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, new()
    {
        private readonly AppDbContext _context;

        public EFBaseRepository(AppDbContext context)
        {
            _context = context;
        }



        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> exp = null, params string[] includes)
        {
            IQueryable<TEntity> query = GetQuery(includes);

            return exp is null
                ? await query.ToListAsync()
                : await query.Where(exp).ToListAsync();

        }


        public async Task<List<TEntity>> GetAllPaginatedAsync(int page, int size, Expression<Func<TEntity, bool>> exp = null, params string[] includes)
        {
            IQueryable<TEntity> query = GetQuery(includes);

            return exp is null
                ? await query.Skip((page - 1) * size).Take(size).ToListAsync()
                : await query.Where(exp).Skip((page - 1) * size).Take(size).ToListAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> exp, params string[] includes)
        {
            IQueryable<TEntity> query = GetQuery(includes);

            return await query.Where(exp).FirstOrDefaultAsync();
        }

        public async Task<bool> IsExistsAsync(Expression<Func<TEntity, bool>> exp)
        {
            return await _context.Set<TEntity>().AnyAsync(exp);
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }
        public async Task CreateAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        private IQueryable<TEntity> GetQuery(string[] includes)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            if (includes is not null)
            {
                foreach (var item in includes)
                {
                    query.Include(item);
                }
            }

            return query;
        }
    }
}
