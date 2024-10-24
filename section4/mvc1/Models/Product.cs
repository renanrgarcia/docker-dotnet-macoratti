using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc1.Models
{
    public class Product
    {
        public Product() { }
        public Product(string name, string category, decimal price)
        {
            Name = name;
            Category = category;
            Price = price;
        }
        public Product(int productId, string name, string category, decimal price)
        {
            ProductId = productId;
            Name = name;
            Category = category;
            Price = price;
        }

        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public decimal Price { get; set; }
    }
}