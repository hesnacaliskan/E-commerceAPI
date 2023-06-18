using MediatR;
using Microsoft.AspNetCore.Mvc;
using SimpraFinalProject.Application.Features.Commands.Categories.CreateCategory;
using SimpraFinalProject.Application.Features.Commands.Categories.RemoveCategory;
using SimpraFinalProject.Application.Features.Commands.Categories.UpdateCategory;
using SimpraFinalProject.Application.Features.Queries.Categories.GetAllCategory;
using System.Net;

namespace SimpraFinalProject.API.Controllers
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
        public async Task<IActionResult> Post(CreateCategoryCommandRequest createCategoryCommandRequest)
        {
            CreateCategoryCommandResponse response = await _mediator.Send(createCategoryCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateCategoryCommandRequest updateCategoryCommandRequest)
        {
            UpdateCategoryCommandResponse response = await _mediator.Send(updateCategoryCommandRequest);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveCategoryCommandRequest removeCategoryCommandRequest)
        {
            RemoveCategoryCommandResponse response = await _mediator.Send(removeCategoryCommandRequest);
            return Ok();
        }
    }
}
