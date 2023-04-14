using FirstWebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace FirstWebApi.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}

        public DbSet<Book> Books{ get; set; }
    }
}
