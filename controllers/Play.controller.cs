using CricketSimulator.Services;
using Microsoft.AspNetCore.Mvc;

namespace CricketSimulator.Controllers
{
    [ApiController]
    [Route("play")]
    public class PlayController : ControllerBase
    {


        [HttpGet]
        public IActionResult Get()
        {
            List<int> playingNumbers = ConstantService.GetPlayingNumbers();
            int numberLength = playingNumbers.Count;
            Random random = new Random();
            int playedNumber = random.Next(0, numberLength);
            return Ok(playingNumbers[playedNumber]);
        }
    }
}