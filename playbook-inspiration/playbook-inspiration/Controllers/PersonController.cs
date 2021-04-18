using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Commands;
using Core.Models;
using Core.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace playbook_inspiration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<PersonModel>> Get() {

            return await _mediator.Send(new GetPersonListQuery());
        }

        [HttpGet("{id}")]
        public async Task<PersonModel> Get(int id)
        {
            return await _mediator.Send(new GetPersonByIdQuery(id));
        }

        [HttpPost]
        public async Task<PersonModel> PostAsync([FromBody] PersonModel value)
        {
            var model = new InsertPersonCommand(value.FirstName
                , value.LastName);
            return await _mediator.Send(model);
        }
    }

}
