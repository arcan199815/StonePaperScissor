using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace StonePaperScissor.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private readonly ILogger<GameController> _logger;

        public GameController(ILogger<GameController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAll() {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetGameById(int ids)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult SetGame(int user1, int user2, int move1, int move2)
        {
            return Ok();
        }
    }
}
