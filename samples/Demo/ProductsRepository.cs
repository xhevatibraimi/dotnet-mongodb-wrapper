using MongoDB.Driver.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Demo
{
    public class ProductsRepository : MongoWrapper<Product>
    {
        public ProductsRepository(MongoDbConfig config) : base(config) { }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await GetQuery().ToListAsync();
        }
    }
}
