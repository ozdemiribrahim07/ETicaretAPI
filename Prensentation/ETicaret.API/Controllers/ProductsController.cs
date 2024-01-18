using ETicaret.Application.Features.Products.Command.ProductCreate;
using ETicaret.Application.Features.Products.Command.ProductDelete;
using ETicaret.Application.Features.Products.Command.ProductUpdate;
using ETicaret.Application.Features.Products.Queries.GetAllProducts;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await mediator.Send(new GetAllProductsQueryRequest());
            return Ok(response);
        }


        [HttpPost]
        public async Task<IActionResult> Add(CreateProductCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateProductCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }


        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteProductCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }


    }
}
