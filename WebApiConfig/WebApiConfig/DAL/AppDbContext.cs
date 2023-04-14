using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Reflection;
using WebApiConfig.Configurations;
using WebApiConfig.Entities;

namespace WebApiConfig.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>().HasKey(p => p.Id);
            //modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired().HasMaxLength(255).HasColumnType(SqlDbType.NVarChar.ToString());
            //modelBuilder.Entity<Product>().Property(p=>p.Price).IsRequired().HasMaxLength(100);
            //modelBuilder.Entity<Product>().Property(p=>p.IsDeleted);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { get; set; }


    }
}
