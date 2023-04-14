using WebApiConfig.DAL.Repositories.Abstracts;
using WebApiConfig.DAL.Repositories.Concretes.EntityFramework;

namespace WebApiConfig.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private IProductRepository _productRepository;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public IProductRepository ProductRepository => _productRepository = _productRepository ?? new EFProductRepository(_context);

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
