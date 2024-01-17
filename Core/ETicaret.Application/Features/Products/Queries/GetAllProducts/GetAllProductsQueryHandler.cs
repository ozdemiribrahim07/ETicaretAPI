using ETicaret.Application.Interfaces.UnitOfWork;
using ETicaret.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetAllProductsQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<IList<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {

            var products = await unitOfWork.GetReadRepository<Product>().GetAllAsync();

            List<GetAllProductsQueryResponse> response = new();

            foreach (var product in products)
            {
                response.Add(new GetAllProductsQueryResponse
                {
                    ProductName = product.ProductName,
                    ProductDesc = product.ProductDesc,
                    ProductDiscount = product.ProductDiscount,
                    ProductPrice = product.ProductPrice - (product.ProductPrice * product.ProductDiscount / 100),
                });
            }

            return response;
        }
    }

}
