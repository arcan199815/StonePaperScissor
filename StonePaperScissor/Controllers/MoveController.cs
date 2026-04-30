using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace StonePaperScissor.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoveController : ControllerBase
    {
        private readonly ILogger<MoveController> _logger;

        public MoveController(ILogger<MoveController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetMoveById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult SetMove(string username)
        {
            return Ok();
        }
    }
}
