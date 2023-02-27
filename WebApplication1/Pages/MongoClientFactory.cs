using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace WebApplication1.Pages
{
    public class MongoClientFactory
    {
        MongoClient mongoClient;
        IMongoDatabase db;
        public MongoClientFactory()
        {
            mongoClient = new MongoClient("mongodb://localhost:27017");
        }
        public MongoClient GetConnectionString()
        {
            return mongoClient;
        }


        public IMongoDatabase GetDatabase(string dbName)
        {
            db= mongoClient.GetDatabase(dbName);
            return db;
        }


        public void CreateCollection(string collectionName)
        {
            db.CreateCollection(collectionName);
        }


        public string CollectionList()
        {
            var collections = db.ListCollectionNames().ToList();
            return string.Join(',', collections);
        }

        public IMongoCollection<BsonDocument> GetCollection(string collectionName)
        {
            return db.GetCollection<BsonDocument>(collectionName);
        }
        public IMongoCollection<T> GetPocoCollection<T>(string collectionName)
        {
            return db.GetCollection<T>(collectionName);
        }

    }
}