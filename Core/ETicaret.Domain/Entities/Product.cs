using ETicaret.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Entities
{
    public class Product : BaseEntity
    {
        private readonly string name;
        private readonly string desc;
        private readonly decimal price;
        private readonly decimal discount;

        public Product()
        {
            
        }



        public Product(string name , string desc, decimal price, decimal discount, int brandId)
        {
            this.name = name;
            this.desc = desc;
            this.price = price;
            this.discount = discount;
            BrandId = brandId;
        }


        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public int BrandId { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductDiscount { get; set; }
        public Brand Brand { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
