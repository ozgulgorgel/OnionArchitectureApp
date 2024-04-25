using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionArchitectureApp.Application.Features.Commands;
using OnionArchitectureApp.Application.Features.Queries;

namespace OnionArchitectureApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {

        private readonly IMediator mediatr; 
        public ApiController(IMediator _mediator) 
        {
            this.mediatr = _mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllProductQuery();
            return Ok(await mediatr.Send(query));

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetProductByIdQuery();
            query.Id = id;
            return Ok(await mediatr.Send(query));

        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommand command)
        {
            return Ok(await mediatr.Send(command));
        }
    }
}
