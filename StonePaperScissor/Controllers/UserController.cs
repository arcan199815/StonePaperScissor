using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace StonePaperScissor.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetUserById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult SetUser(string username)
        {
            return Ok();
        }
    }
}
