using ApiMediatR.Models;
using System;
using System.Threading.Tasks;

namespace ApiMediatR.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public async Task<Customer> GetCustomer(Guid customerId)
        {
            Customer customer = new Customer
            {
                CustomerId = customerId,
                Name = "Macoratti"
            };
            return customer;
        }

        public async Task<Guid> CreateCustomer(Customer customer)
        {
            return Guid.NewGuid();
        }
    }
}
