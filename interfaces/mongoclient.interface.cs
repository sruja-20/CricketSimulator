using MongoDB.Driver;

namespace CricketSimulator.Interfaces
{
    public interface IMongoClientHelper
    {
        public IMongoCollection<T> GetCollection<T>(string collectionName);
    }
}