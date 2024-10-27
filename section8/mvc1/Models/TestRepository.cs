namespace mvc1.Models
{
    public class TestRepository : IRepository
    {
        private static readonly Product[] products =
        [
            new() { Name = "Kayak", Category = "Watersports", Price = 275M },
            new() { Name = "Lifejacket", Category = "Watersports", Price = 48.95M },
            new() { Name = "Soccer Ball", Category = "Soccer", Price = 19.50M },
        ];

        public IEnumerable<Product> Products { get => products; }
    }
}