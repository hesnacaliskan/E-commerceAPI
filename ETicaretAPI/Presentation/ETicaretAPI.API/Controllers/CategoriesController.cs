using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ETicaretAPI.Application.Features.Commands.Categories.CreateCategory;
using ETicaretAPI.Application.Features.Commands.Categories.RemoveCategory;
using ETicaretAPI.Application.Features.Commands.Categories.UpdateCategory;
using ETicaretAPI.Application.Features.Queries.Categories.GetAllCategory;
using System.Net;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

        readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {

            this._mediator = mediator;
        }

        [HttpGet]
        public async Task<List<GetAllCategoryQueryResponse>> Get()
        {
            return await _mediator.Send(new GetAllCategoryQueryRequest());
            
        }


        [HttpPost]
        [Authorize(AuthenticationSchemes = "Admin")]
        public async Task<IActionResult> Post(CreateCategoryCommandRequest createCategoryCommandRequest)
        {
            CreateCategoryCommandResponse response = await _mediator.Send(createCategoryCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        [Authorize(AuthenticationSchemes = "Admin")]
        public async Task<IActionResult> Put(UpdateCategoryCommandRequest updateCategoryCommandRequest)
        {
            UpdateCategoryCommandResponse response = await _mediator.Send(updateCategoryCommandRequest);
            return Ok();
        }

        [HttpDelete("{Id}")]
        [Authorize(AuthenticationSchemes = "Admin")]
        public async Task<IActionResult> Delete([FromRoute] RemoveCategoryCommandRequest removeCategoryCommandRequest)
        {
            RemoveCategoryCommandResponse response = await _mediator.Send(removeCategoryCommandRequest);
            return Ok();
        }
    }
}
