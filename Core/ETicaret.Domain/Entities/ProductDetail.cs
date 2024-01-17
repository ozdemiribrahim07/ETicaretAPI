using ETicaret.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Entities
{
    public class ProductDetail : BaseEntity
    {

        public ProductDetail()
        {
            
        }


        public ProductDetail(string detailTitle, string detailDesc, int categoryId)
        {
            DetailTitle = detailTitle;
            DetailDesc = detailDesc;
            CategoryId = categoryId;
        }

        public string DetailTitle { get; set; }
        public string DetailDesc { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
