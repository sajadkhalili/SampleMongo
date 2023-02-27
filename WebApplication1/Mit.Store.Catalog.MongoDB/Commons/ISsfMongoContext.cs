using MongoDB.Driver;


namespace WebApplication1.Mit.Store.Catalog.MongoDB.Commons
{
    public interface ISsfMongoContext
    {
        IMongoClient Client { get; }

        IMongoDatabase Database { get; }



        IMongoCollection<T> Collection<T>();
    }
}
