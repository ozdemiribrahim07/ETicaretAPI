using ETicaret.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistance.Contexts
{
    public class TicaretContext : DbContext
    {

        public TicaretContext()
        {

        }

        public TicaretContext(DbContextOptions options) : base(options)
        {
        }



        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }


        protected override void OnModelCreating(ModelBuilder b)
        {
            base.OnModelCreating(b);
            b.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }



    }



}
