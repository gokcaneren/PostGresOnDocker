using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleApi.Models;

namespace SimpleApi.Dal.Seeds
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category{
                    Id=1,
                    Name="Phone"
                },
                 new Category{
                    Id=2,
                    Name="Laptop"
                },
                 new Category{
                    Id=3,
                    Name="Desktop"
                }
            );
        }
    }
}