using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(p => p.Name).IsRequired().HasMaxLength(255);
        builder.Property(p => p.IsDeleted).HasDefaultValue(false);
        builder.Property(p => p.CreatedDate).HasDefaultValueSql("GETUTCDATE()");
        builder.Property(p => p.Price).IsRequired();
        builder.Property(p => p.Count).IsRequired();
    }
}
