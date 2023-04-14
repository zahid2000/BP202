using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebApiConfig.Core.DAL.Repositories.Concretes.EntityFramework;
using WebApiConfig.DAL.Repositories.Abstracts;
using WebApiConfig.Entities;

namespace WebApiConfig.DAL.Repositories.Concretes.EntityFramework
{
    public class EFProductRepository :EFBaseRepository<Product>,IProductRepository
    {
        private readonly AppDbContext _context;
        public EFProductRepository(AppDbContext context):base(context)
        {
            _context = context;
        }
    }
}
