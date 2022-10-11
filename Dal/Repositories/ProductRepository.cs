using SimpleApi.Models;

namespace SimpleApi.Dal.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DbbbContext context) : base(context)
        {
        }
    }
}