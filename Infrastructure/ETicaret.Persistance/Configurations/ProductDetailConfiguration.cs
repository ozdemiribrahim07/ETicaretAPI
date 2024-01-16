using Bogus;
using ETicaret.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETicaret.Persistance.Configurations
{
    public class ProductDetailConfiguration : IEntityTypeConfiguration<ProductDetail>
    {
        public void Configure(EntityTypeBuilder<ProductDetail> b)
        {

            Faker faker = new("en");

            ProductDetail productDetail = new()
            {
                Id = 1,
                DetailTitle = faker.Lorem.Sentence(),
                DetailDesc = faker.Lorem.Sentence(6),
                CategoryId = 1,
                CreatedTime = DateTime.Now,
                IsDeleted = false
            };

            ProductDetail productDetail2 = new()
            {
                Id = 2,
                DetailTitle = faker.Lorem.Sentence(),
                DetailDesc = faker.Lorem.Sentence(6),
                CategoryId = 1,
                CreatedTime = DateTime.Now,
                IsDeleted = false
            };

            ProductDetail productDetail3 = new()
            {
                Id = 3,
                DetailTitle = faker.Lorem.Sentence(),
                DetailDesc = faker.Lorem.Sentence(6),
                CategoryId = 2,
                CreatedTime = DateTime.Now,
                IsDeleted = false
            };


            b.HasData(productDetail, productDetail2, productDetail3);


        }
    }
}
