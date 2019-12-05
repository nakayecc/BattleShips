using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server.Models.Board;
using Server.Services;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowMyOrigin")]
    public class EnemyController : ControllerBase
    {
        private readonly IGame game;

        public EnemyController(IGame game)
        {
            this.game = game;
        }

        // GET: api/Player
        [HttpGet]
        public List<Square> Get()
        {
            return game.Player2.Ocean.Board;
        }


        // POST: api/Player
        [HttpPost]
        public void Post([FromBody] Coordinates coordinates)
        {
            game.Shoot(coordinates);
        }

        // PUT: api/Player/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}