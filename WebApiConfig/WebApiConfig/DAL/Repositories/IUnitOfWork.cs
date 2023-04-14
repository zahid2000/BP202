using WebApiConfig.DAL.Repositories.Abstracts;

namespace WebApiConfig.DAL.Repositories
{
    public interface IUnitOfWork
    {
        public IProductRepository ProductRepository { get;  }
        Task SaveAsync();
    }
}
