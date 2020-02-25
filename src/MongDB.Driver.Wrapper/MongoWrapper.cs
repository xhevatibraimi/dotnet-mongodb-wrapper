using MongoDB.Driver.Linq;

namespace MongoDB.Driver.Wrapper
{
    public abstract class MongoWrapper<T> where T : new()
    {
        protected readonly MongoDbConfig Config;
        protected string CollectionName;
        protected IMongoClient Client;
        protected IMongoDatabase Database;
        protected IMongoCollection<T> Collection;

        public MongoWrapper(MongoDbConfig config)
        {
            Config = config;
            Client = new MongoClient(config.ConnectionString);
            Database = Client.GetDatabase(config.Database);
            CollectionName = GetCollectionName();
            Collection = Database.GetCollection<T>(CollectionName);
        }

        protected virtual string GetCollectionName()
        {
            return Config.Collections[$"{ typeof(T).Name}s"];
        }

        public IMongoQueryable<T> GetQuery()
        {
            return Collection.AsQueryable();
        }
    }
}
