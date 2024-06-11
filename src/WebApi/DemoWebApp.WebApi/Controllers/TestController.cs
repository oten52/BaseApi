using DemoWebApp.Application.MediatR.Queries.Test;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApp.WebApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class TestController : BaseController
    {
        private readonly IMediator _mediator;
        public TestController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("Test")]
        public async Task<IActionResult> Test()
        {
            var query = new GetAllProductsQuery();

            return Ok(await _mediator.Send(query));
        }
    }
}
