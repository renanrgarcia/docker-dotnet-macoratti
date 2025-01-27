using ApiMediatR.Models;
using MediatR;
using System;

namespace ApiMediatR.Handlers.Request
{
    public class CreateCustomerRequest : IRequest<Guid>
    {
        public Customer Customer { get; set; }
    }
}
