using ApiMediatR.Handlers.Request;
using ApiMediatR.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ApiMediatR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersComMediatorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomersComMediatorController(IMediator mediator) => _mediator = mediator;

        [HttpGet("get-customer/{customerId:Guid}")]
        public async Task<Customer> GetCustomer(Guid customerId) =>
           await _mediator.Send(new GetCustomerRequest { CustomerId = customerId });

        [HttpPost("create-customer")]
        public async Task<Guid> CreatCustomer(Customer customer) =>
            await _mediator.Send(new CreateCustomerRequest { Customer = customer });

    }
}
