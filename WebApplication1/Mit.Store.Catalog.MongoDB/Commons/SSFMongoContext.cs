using Microsoft.Extensions.Options;
using MongoDB.Driver;


namespace WebApplication1.Mit.Store.Catalog.MongoDB.Commons
{
    public abstract class SSFMongoContext : ISsfMongoContext
    {
        public IMongoClient Client { get; private set; }
        public IMongoDatabase Database { get; private set; }


        //public SSFMongoContext()
        //{
        //    Client = new MongoClient("");
        //    Database = Client.GetDatabase("");


        //}
        public SSFMongoContext(IOptions<MongoConnectionOptions> dbOptions)
        {
            var settings = dbOptions.Value;

            Client = new MongoClient(settings.ConnectionString);
            Database = Client.GetDatabase(settings.DatabaseName);

        }

        public IMongoCollection<T> Collection<T>()
        {
            return Database.GetCollection<T>(typeof(T).Name);
        }





    }
}
