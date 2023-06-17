using MediatR;
using Microsoft.AspNetCore.Mvc;
using SimpraFinalProject.Application.Features.Commands.Products.CreateProduct;
using SimpraFinalProject.Application.Features.Commands.Products.RemoveProduct;
using SimpraFinalProject.Application.Features.Commands.Products.UpdateProduct;
using SimpraFinalProject.Application.Features.Queries.Products.GetAllProduct;
using System.Net;

namespace SimpraFinalProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {

            this._mediator = mediator;
        }

        [HttpGet]
        public async Task<List<GetAllProductQueryResponse>> Get()
        {
            return await _mediator.Send(new GetAllProductQueryRequest());
            
        }


        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommandRequest createProductCommandRequest)
        {
            CreateProductCommandResponse response = await _mediator.Send(createProductCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateProductCommandRequest updateProductCommandRequest)
        {
            UpdateProductCommandResponse response = await _mediator.Send(updateProductCommandRequest);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveProductCommandRequest removeProductCommandRequest)
        {
            RemoveProductCommandResponse response = await _mediator.Send(removeProductCommandRequest);
            return Ok();
        }
    }
}
