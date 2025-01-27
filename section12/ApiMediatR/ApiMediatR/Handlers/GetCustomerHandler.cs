using ApiMediatR.Handlers.Request;
using ApiMediatR.Models;
using ApiMediatR.Repositories;
using ApiMediatR.Services;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ApiMediatR.Handlers
{
    public class GetCustomerHandler : IRequestHandler<GetCustomerRequest, Customer>
    {
        private readonly IValidationService _validationService;
        private readonly ICustomerRepository _customerRepository;

        public GetCustomerHandler(IValidationService validationService,
            ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
            _validationService = validationService;
        }

        public async Task<Customer> Handle(GetCustomerRequest request, 
            CancellationToken cancellationToken)
        {
            _validationService.Validate<Guid>(request.CustomerId);
            return await _customerRepository.GetCustomer(request.CustomerId);
        }
    }
}
