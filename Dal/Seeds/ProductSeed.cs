using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleApi.Models;

namespace SimpleApi.Dal.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product{
                    Id=1,
                    Name="Xiaomi Mi 10 Pro",
                    Stock=15,
                    CategoryId=1
                },
                new Product{
                    Id=2,
                    Name="Samsung A52S",
                    Stock=13,
                    CategoryId=1
                },
                new Product{
                    Id=3,
                    Name="Asus TUF Gaming Laptop",
                    Stock=11,
                    CategoryId=2
                }
            );
        }
    }
}