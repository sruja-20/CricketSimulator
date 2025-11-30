using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CricketSimulator.Models
{
    public class TeamModel
    {
        public string Name { get; set; } = "";

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = "";

    }
}