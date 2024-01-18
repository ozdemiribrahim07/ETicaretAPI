using ETicaret.Application.Interfaces.UnitOfWork;
using ETicaret.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Features.Products.Command.ProductCreate
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;

        public CreateProductCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        public async Task Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {

            Product product = new(request.ProductName, request.ProductDesc, request.ProductPrice, request.ProductDiscount, request.BrandId);

            await unitOfWork.GetWriteRepository<Product>().AddAsync(product);

            if (await unitOfWork.SaveAsync() > 0)
            {
                foreach (var item in request.CategoryIds)
                {
                    await unitOfWork.GetWriteRepository<ProductCategory>().AddAsync(new()
                    {
                        ProductId = product.Id,
                        CategoryId = item
                    });

                    await unitOfWork.SaveAsync();
                }
            }


        }
    }
}
