using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Features.Products.Command.ProductCreate
{
    public class CreateProductCommandRequest : IRequest
    {
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public int BrandId { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductDiscount { get; set; }

        public IList<int> CategoryIds { get; set; }
    }
}
