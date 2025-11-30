using CricketSimulator.Models;
using MongoDB.Driver;

namespace CricketSimulator.Interfaces
{
    public interface ITeamRepository
    {
        Task<List<TeamModel>> GetTeams();
        Task<TeamModel> CreateTeam(TeamModel team);

        Task<TeamModel> UpdateTeam(string id, TeamModel team);

        Task DeleteTeam(string id);


        IMongoCollection<T> GetCollection<T>(string name);
    }
}