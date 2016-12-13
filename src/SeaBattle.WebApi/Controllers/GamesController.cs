using Microsoft.AspNetCore.Mvc;
using SeaBattle.WebApi.Data.Games;
using SeaBattle.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeaBattle.WebApi.Controllers
{
    [Route("[controller]")]
    public class GamesController : BaseController
    {
        private readonly IGameRepository _repository;

        public GamesController(IGameRepository repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        //http://localhost:5000/games
        public IActionResult Get()
        {
            try
            {
                var gameID = _repository.Get();
                return Ok(gameID);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("{gameID}/start")]
        //http://localhost:5000/games/56bb18eb-fefb-4741-b834-eb5b0bfc657f/start
        public IActionResult Start(StartData data)
        {
            try
            {
                _repository.Start(data.GameID);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("{gameID}/join")]
        //http://localhost:5000/games/56bb18eb-fefb-4741-b834-eb5b0bfc657f/join
        public IActionResult Join(JoinData data)
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
