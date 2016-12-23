using SeaBattle.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeaBattle.WebApi.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly SeaBattle.Engine.Models.Game _game;

        public GameRepository()
        {
            _game = SeaBattle.Engine.Builders.GameBuilder.Build();
        }

        public Guid Get()
        {
            return _game.ID;
        }

        public void Start(Guid gameID)
        {
            if (gameID != _game.ID)
                throw new ArgumentOutOfRangeException($"Game {gameID} has not been found");

            _game.Start();
        }
    }
}
