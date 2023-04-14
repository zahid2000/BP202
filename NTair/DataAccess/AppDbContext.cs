using Core.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DataAccess;

public class AppDbContext:IdentityDbContext<AppUser>
{
	public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        builder.Entity<Product>().HasData(
            new Product
            {
                Id=5,
                Name="Samsung",
                Count=5,
                Price=1200,
                CreatedDate=DateTime.UtcNow,
                IsDeleted=false,
                Description="Good Phone"                
            },
             new Product
             {
                 Id=6,
                 Name = "Samsung",
                 Count = 5,
                 Price = 1200,
                 CreatedDate = DateTime.UtcNow,
                 IsDeleted = false,
                 Description = "Good Phone"
             });
        base.OnModelCreating(builder);
    }
    public DbSet<Product> Products{ get; set; }
}
