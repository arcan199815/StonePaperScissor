using Microsoft.Extensions.Logging;
using StonePaperScissorRun.Repository.Interface;

namespace StonePaperScissor.Services
{
    public class GameRepository : IGameRepository
    {
        private readonly ILogger<GameRepository> _logger;

        public GameRepository(ILogger<GameRepository> logger)
        {
            _logger = logger;
        }


    }
}
