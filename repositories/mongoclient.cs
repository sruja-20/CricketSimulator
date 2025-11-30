

using CricketSimulator.Interfaces;
using MongoDB.Driver;

namespace CricketSimulator.Repositories
{
    public class MongoClientHelper : IMongoClientHelper
    {
        string _connectionString = "mongodb://localhost:27017/";
        IMongoClient _client;
        IMongoDatabase _database;
        public MongoClientHelper()
        {
            _client = new MongoClient(_connectionString);
            _database = _client.GetDatabase("CricketSimulator");
        }


        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return _database.GetCollection<T>(collectionName);
        }

    }
}