using CricketSimulator.Interfaces;
using CricketSimulator.Models;
using MongoDB.Driver;

namespace CricketSimulator.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly IMongoClientHelper _mongoClient;

        public TeamRepository(IMongoClientHelper mongoClient)
        {
            _mongoClient = mongoClient;
        }

        public async Task<TeamModel> CreateTeam(TeamModel team)
        {
            try
            {
                var collection = GetCollection<TeamModel>("Teams");
                await collection.InsertOneAsync(team);
                return team;

            }
            catch (Exception ex)
            {
                throw new Exception("Error while creating team", ex);
            }

        }


        public IMongoCollection<T> GetCollection<T>(string name)
        {
            return this._mongoClient.GetCollection<T>(name);
        }

        public async Task<List<TeamModel>> GetTeams()
        {
            try
            {

                var collection = GetCollection<TeamModel>("Teams");
                var result = await collection.Find(_ => true).ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}", ex);
            }
        }

        public async Task<TeamModel> UpdateTeam(string id, TeamModel team)
        {
            try
            {
                var collection = GetCollection<TeamModel>("Teams");
                var filter = Builders<TeamModel>.Filter.Eq(team => team.Id, id);
                await collection.ReplaceOneAsync(filter, team);
                return team;

            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}", ex);
            }
        }
        public async Task DeleteTeam(string id)
        {
            try
            {
                var collection = GetCollection<TeamModel>("Teams");
                var filter = Builders<TeamModel>.Filter.Eq(team => team.Id, id);
                await collection.DeleteOneAsync(filter);
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }
    }

}