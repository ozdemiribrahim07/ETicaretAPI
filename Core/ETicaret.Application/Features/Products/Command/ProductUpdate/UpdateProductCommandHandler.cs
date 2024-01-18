using ETicaret.Application.Interfaces.AutoMapper;
using ETicaret.Application.Interfaces.UnitOfWork;
using ETicaret.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Features.Products.Command.ProductUpdate
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public UpdateProductCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }


        public async Task Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {

            var product = await unitOfWork.GetReadRepository<Product>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            var map = mapper.Map<Product, UpdateProductCommandRequest>(request);

            var categories = await unitOfWork.GetReadRepository<ProductCategory>()
                .GetAllAsync(x => x.ProductId == product.Id);

            await unitOfWork.GetWriteRepository<ProductCategory>().HardDeleteAsyncRange(categories);

            foreach (var id in request.CategoryIds)
            {
                await unitOfWork.GetWriteRepository<ProductCategory>().AddAsync(new()
                {
                    CategoryId = id,
                    ProductId = product.Id
                });
            }

            await unitOfWork.GetWriteRepository<Product>().UpdateAsync(product);
            await unitOfWork.SaveAsync();

        }
    }
}
