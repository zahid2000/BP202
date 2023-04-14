namespace DataAccess.Repositories.Concrete;

public class ProductRepository : EntityRepositoryBase<Product, AppDbContext>, IProductRepository
{
    public ProductRepository(AppDbContext context) : base(context){}
}
