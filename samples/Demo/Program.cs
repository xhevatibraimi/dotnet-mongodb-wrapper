using MongoDB.Driver.Wrapper;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new MongoDbConfig();
            config.ConnectionString = "mongodb://username:password@localhost:27017/database-name";
            config.Database = "ProductsDatabase";
            config.Collections.Add("Products", "products-collection");
            var repository = new ProductsRepository(config);
            var poroducts = repository.GetProductsAsync().GetAwaiter().GetResult();
        }
    }
}
