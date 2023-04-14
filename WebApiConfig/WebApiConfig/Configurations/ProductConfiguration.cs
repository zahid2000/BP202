using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;
using WebApiConfig.Entities;

namespace WebApiConfig.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(255).HasColumnType(SqlDbType.NVarChar.ToString());
            builder.Property(p => p.Price).IsRequired().HasMaxLength(100);
            builder.Property(p => p.IsDeleted).HasDefaultValue(false);
            builder.Property(p => p.CreatedDate).HasDefaultValueSql("GetUTCDate()");
            
        }
    }
}
