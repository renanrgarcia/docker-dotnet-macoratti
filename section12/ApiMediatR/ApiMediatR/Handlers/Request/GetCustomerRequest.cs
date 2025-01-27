using ApiMediatR.Models;
using MediatR;
using System;

namespace ApiMediatR.Handlers.Request
{
    public class GetCustomerRequest : IRequest<Customer>
    {
        public Guid CustomerId { get; set; }
    }
}
