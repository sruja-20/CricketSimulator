using System.Threading.Tasks;
using CricketSimulator.Interfaces;
using CricketSimulator.Models;
using Microsoft.AspNetCore.Mvc;
namespace CricketSimulator.Controllers
{
    [ApiController]
    [Route("team")]
    public class TeamController : Controller
    {

        private readonly ITeamsService _teamsService;

        public TeamController(ITeamsService teamsService)
        {
            _teamsService = teamsService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var teams = await _teamsService.GetTeams();
                return Ok(teams);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TeamModel team)
        {
            try
            {

                await this._teamsService.CreateTeam(team);
                return Ok(team);
            }
            catch (Exception ex)
            {
                throw new Exception("", ex);
            }
        }

        [HttpPut]

        public async Task<IActionResult> Update([FromBody] TeamModel team)
        {
            try
            {
                await _teamsService.UpdateTeam(team);
                return Ok(team);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]

        public async Task<IActionResult> Delete([FromQuery] string id)
        {
            try
            {
                await this._teamsService.DeleteTeam(id);
                return Ok("Team deleted successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }

}