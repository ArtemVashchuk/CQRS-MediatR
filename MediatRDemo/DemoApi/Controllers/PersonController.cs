using DemoLibrary.Models;
using DemoLibrary.Queries;
using DemoLibrary.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<PersonModel>> Get()
        {
            return await _mediator.Send(new GetPersonListQuery());
        }

        [HttpGet("{id}")]
        public async Task<PersonModel> Get(int id)
        {
            return await _mediator.Send(new GetPersonByIdQuery(id));
        }

        [HttpPost()]
        public async Task<PersonModel> Create(PersonModel person)
        {
            return await _mediator.Send(new CreatePersonCommand(person));
        }
    }
}
