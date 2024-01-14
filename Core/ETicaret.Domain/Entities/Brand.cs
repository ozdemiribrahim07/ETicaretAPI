using ETicaret.Domain.Common;
using ETicaret.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Entities
{
    public class Brand : BaseEntity
    {
        public Brand()
        {
            

        }


        public Brand(string brandName)
        {
            BrandName = brandName;
        }

        public string BrandName { get; set; }
    }
}

