using CricketSimulator.Models;

namespace CricketSimulator.Interfaces
{
    public interface ITeamsService
    {
        Task<List<TeamModel>> GetTeams();
        Task<TeamModel> CreateTeam(TeamModel team);

        Task<TeamModel> UpdateTeam(TeamModel team);

        Task DeleteTeam(string id);


    }
}