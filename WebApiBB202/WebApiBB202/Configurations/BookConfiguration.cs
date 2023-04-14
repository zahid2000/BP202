using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiBB202.Entities;

namespace WebApiBB202.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(b=>b.IsDelete).HasDefaultValue(false);
            builder.Property(b=>b.Price).IsRequired().HasMaxLength(50).HasDefaultValue(0);
        }
    }
}
