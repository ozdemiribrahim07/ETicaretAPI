using ETicaret.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Entities
{
    public class ProductCategory : IEntityBase
    {
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public Category Category { get; set; }


    }
}
