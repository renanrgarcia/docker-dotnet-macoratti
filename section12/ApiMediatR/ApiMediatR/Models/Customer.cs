using System;

namespace ApiMediatR.Models
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string Name { get; set; }
    }
}
