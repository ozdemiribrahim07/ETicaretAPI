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
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> b)
        {

            b.HasKey(x => new
            {
                x.ProductId,
                x.CategoryId
            });

            b.HasOne(x => x.Category).WithMany(pc => pc.ProductCategories).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.Cascade);

            b.HasOne(x => x.Product).WithMany(pc => pc.ProductCategories).HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
