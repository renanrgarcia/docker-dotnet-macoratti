
namespace mvc1.Models
{
    public class ProductRepository : IRepository
    {
        private AppDbContext context;
        public ProductRepository(AppDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Product>? Products => context.Products;
    }
}