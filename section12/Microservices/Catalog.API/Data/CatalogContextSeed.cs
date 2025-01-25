using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetMyProducts());
            }
        }

        private static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "602d214b4f4f4b0b88cf4f71",
                    Name = "IPhone X",
                    Category = "Smart Phone",
                    Description = "This is the long description of IPhone X",
                    Image = "product-1.png",
                    Price = 950.00M
                },
                new Product()
                {
                    Id = "602d214b4f4f4b0b88cf4f72",
                    Name = "Samsung Galaxy S20",
                    Category = "Smart Phone",
                    Description = "This is the long description of Samsung Galaxy S20",
                    Image = "product-2.png",
                    Price = 800.00M
                },
                new Product()
                {
                    Id = "602d214b4f4f4b0b88cf4f73",
                    Name = "Huawei P30 Pro",
                    Category = "Smart Phone",
                    Description = "This is the long description of Huawei P30 Pro",
                    Image = "product-3.png",
                    Price = 900.00M
                }
            };
        }
    }
}