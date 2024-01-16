using Bogus.DataSets;
using ETicaret.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETicaret.Persistance.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> b)
        {
            Category category = new()
            {
                Id = 1,
                CategoryName = "Elektronik",
                IsDeleted = false,
                Priority = 1,
                ParentId = 0,
                CreatedTime = DateTime.Now,
            };

            Category category2 = new()
            {
                Id = 2,
                CategoryName = "Ev, Yaşam",
                IsDeleted = false,
                Priority = 2,
                ParentId = 0,
                CreatedTime = DateTime.Now,
            };

            Category parent = new()
            {
                Id = 3, 
                CategoryName = "Bilgisayar",
                IsDeleted = false,
                Priority = 1,
                ParentId = 1,
                CreatedTime = DateTime.Now,
            };

            b.HasData(category, category2, parent);
        }
    }
}
