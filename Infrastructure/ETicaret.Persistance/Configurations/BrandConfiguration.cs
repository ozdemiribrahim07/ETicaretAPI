using Bogus;
using ETicaret.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistance.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> b)
        {
            b.Property(x => x.BrandName).HasMaxLength(300);

            Faker faker = new("en");

            Brand brand = new()
            {
                Id = 1,
                BrandName = faker.Commerce.Department(),
                CreatedTime = DateTime.Today,
                IsDeleted = false
            };

            Brand brand2 = new()
            {
                Id = 2,
                BrandName = faker.Commerce.Department(),
                CreatedTime = DateTime.Today,
                IsDeleted = true
            };

            Brand brand3 = new()
            {
                Id = 3,
                BrandName = faker.Commerce.Department(),
                CreatedTime = DateTime.Today,
                IsDeleted = false
            };

            Brand brand4 = new()
            {
                Id = 4,
                BrandName = faker.Commerce.Department(),
                CreatedTime = DateTime.Today,
                IsDeleted = false
            };

            b.HasData(brand, brand2, brand3, brand4);



        }
    }
}
