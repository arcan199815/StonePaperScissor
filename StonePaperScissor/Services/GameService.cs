using Microsoft.AspNetCore.Mvc;
using StonePaperScissor.Services.Interface;
using System.Reflection.Metadata.Ecma335;

namespace StonePaperScissor.Services
{
    public class GameService : IGameService
    {
        private readonly ILogger<GameService> _logger;

        public GameService(ILogger<GameService> logger)
        {
            _logger = logger;
        }

        
    }
}
