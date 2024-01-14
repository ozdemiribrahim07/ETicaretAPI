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

        public required string ProductName { get; set; }
        public required string ProductDesc { get; set; }
        public required int BrandId { get; set; }
        public required decimal ProductPrice { get; set; }
        public required decimal ProductDiscount { get; set; }
        public Brand Brand { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
