
using CodeAcademyShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademyShop.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        void IEntityTypeConfiguration<Product>.Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.HasDiscount)
                .HasDefaultValue(false)
                .IsRequired(false);


            builder.Property(p => p.Descreption)
                .IsRequired(false)
                .HasMaxLength(60);
        }
    }
}
