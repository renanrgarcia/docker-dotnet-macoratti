using ApiMediatR.Models;
using ApiMediatR.Repositories;
using ApiMediatR.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ApiMediatR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersSemMediatorController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IValidationService _serviceValidation;

        public CustomersSemMediatorController(ICustomerRepository customerRepository,
            IValidationService validaService)
        {
            _customerRepository = customerRepository;
            _serviceValidation = validaService;
        }

        [HttpGet("get-customer/{customerId:Guid}")]
        public async Task<Customer> GetCustomer(Guid customerId)
        {
            _serviceValidation.Validate<Guid>(customerId);

            return await _customerRepository.GetCustomer(customerId);
        }

        [HttpPost("create-customer")]
        public async Task<Guid> CreateCustomer([FromBody] Customer newCustomer)
        {
            _serviceValidation.Validate<Customer>(newCustomer);

            var customer = new Customer
            {
                Name = newCustomer.Name
            };

            return await _customerRepository.CreateCustomer(customer);
        }
    }
}
