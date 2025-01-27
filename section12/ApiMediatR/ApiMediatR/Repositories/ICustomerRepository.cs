using ApiMediatR.Models;
using System;
using System.Threading.Tasks;

namespace ApiMediatR.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer> GetCustomer(Guid customerId);
        Task<Guid> CreateCustomer(Customer customer);
    }
}
