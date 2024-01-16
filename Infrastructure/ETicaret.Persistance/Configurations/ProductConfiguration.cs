using Bogus;
using ETicaret.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETicaret.Persistance.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> b)
        {
            Faker faker = new("en");

            Product product = new()
            {
                Id = 1,
                ProductName = faker.Commerce.ProductName(),
                ProductDesc = faker.Commerce.ProductDescription(),
                BrandId = 1,
                ProductDiscount = faker.Random.Decimal(0, 10),
                ProductPrice = faker.Finance.Amount(50, 2000),
                IsDeleted = false
            };

            Product product2 = new()
            {
                Id = 2,
                ProductName = faker.Commerce.ProductName(),
                ProductDesc = faker.Commerce.ProductDescription(),
                BrandId = 2,
                ProductDiscount = faker.Random.Decimal(0, 10),
                ProductPrice = faker.Finance.Amount(50, 2000),
                IsDeleted = false
            };

            Product product3 = new()
            {
                Id = 2,
                ProductName = faker.Commerce.ProductName(),
                ProductDesc = faker.Commerce.ProductDescription(),
                BrandId = 1,
                ProductDiscount = faker.Random.Decimal(0, 10),
                ProductPrice = faker.Finance.Amount(50, 2000),
                IsDeleted = false
            };

            b.HasData(product, product3, product2);

        }
    }
}
