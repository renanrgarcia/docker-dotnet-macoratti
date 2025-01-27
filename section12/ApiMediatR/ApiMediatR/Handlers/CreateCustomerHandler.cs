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
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, Guid>
    {
        private readonly IValidationService _validationService;
        private readonly ICustomerRepository _customerRepository;

        public CreateCustomerHandler(IValidationService validationService,
            ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
            _validationService = validationService;
        }

        public async Task<Guid> Handle(CreateCustomerRequest request, CancellationToken cancellationToken = default)
        {
            _validationService.Validate<Customer>(request.Customer);
            return await _customerRepository.CreateCustomer(request.Customer);
        }
    }
}
