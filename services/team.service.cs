using CricketSimulator.Interfaces;
using CricketSimulator.Models;

namespace CricketSimulator.Services
{
    public class TeamsService : ITeamsService
    {

        private readonly ITeamRepository _teamRepository;

        public TeamsService(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }
        public async Task<TeamModel> CreateTeam(TeamModel team)
        {
            try
            {
                await _teamRepository.CreateTeam(team);
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
                await _teamRepository.DeleteTeam(id);

            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}", ex);
            }
        }

        public Task<List<TeamModel>> GetTeams()
        {
            try
            {
                return _teamRepository.GetTeams();
            }
            catch (Exception ex)
            {
                throw new Exception("", ex);
            }
        }

        public async Task<TeamModel> UpdateTeam(TeamModel team)
        {
            try
            {
                string teamId = team.Id;
                return await _teamRepository.UpdateTeam(teamId, team);
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}", ex);
            }
        }


    }
}