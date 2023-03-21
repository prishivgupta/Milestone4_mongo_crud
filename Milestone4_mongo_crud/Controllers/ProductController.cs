using crud_mongo.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Milestone4_mongo_crud.Commands;
using Milestone4_mongo_crud.Queries;

namespace Milestone4_mongo_crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("GetAllProducts")]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await mediator.Send(new GetAllProductsQuery());
            return Ok(products);
        }

        [HttpGet]
        [Route("GetProductById/{id}")]

        public async Task<ActionResult> GetProductById(string id)
        {
            var product = await mediator.Send(new GetProductByIdQuery(id));
            return Ok(product);
        }


        [HttpPost]
        [Route("AddProduct")]

        public async Task<ActionResult> AddProduct([FromBody] ProductModel product)
        {
            await mediator.Send(new AddProductCommand(product));
            return StatusCode(201);
        }

        [HttpPut]
        [Route("UpdateProduct")]

        public async Task<ActionResult> UpdateProduct([FromBody] ProductModel product)
        {
            await mediator.Send(new UpdateProductCommand(product));
            return StatusCode(201);
        }

        [HttpDelete]
        [Route("DeleteProduct")]

        public async Task<ActionResult> DeleteProduct(string id)
        {
            await mediator.Send(new DeleteProductCommand(id));
            return StatusCode(201);
        }

    }
}
