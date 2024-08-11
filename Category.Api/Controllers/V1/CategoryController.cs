using Category.Application.Operations.Categories.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Category.Api.Controllers.V1
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v1/categories")]
    public class CategoryController : ControllerBase
    {
        private readonly ISender _mediator;
        public CategoryController(ISender mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetCategories(CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(new GetCategoriesQuery(), cancellationToken));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubCategories(int id,CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(new GetSubCategoriesByIdQuery(id), cancellationToken));
        }
    }
}
