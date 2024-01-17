using ETicaret.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Entities
{
    public class Category : BaseEntity
    {
        public Category()
        {
            
        }


        public Category(int parentId, string categoryName, int priority)
        {
            ParentId = parentId;
            CategoryName = categoryName;
            Priority = priority;
        }

        public int ParentId { get; set; }
        public string CategoryName { get; set; }
        public int Priority { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<ProductDetail> ProductDetails { get; set; }

    }
}
