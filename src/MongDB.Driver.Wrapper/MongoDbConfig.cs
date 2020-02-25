using System.Collections.Generic;

namespace MongoDB.Driver.Wrapper
{
    public class MongoDbConfig
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }

        public Dictionary<string, string> Collections { get; set; }

        public MongoDbConfig()
        {
            Collections = new Dictionary<string, string>();
        }
    }
}
