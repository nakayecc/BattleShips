using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Serialization;
using Server.Models.Board;
using Server.Services;


namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowMyOrigin")]
    public class BoardController : ControllerBase
    {
        public BoardController(IGame game)
        {
            this.game = game;
        }

        private readonly IGame game;

        //GET: api/Board
        [HttpGet]
        public List<Square> Get()
        {

            return game.Player1.Ocean.Board;
        }
        
        // GET: api/Board


        // GET: api/Board/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            Console.WriteLine("get");
            return "value";
        }

        // POST: api/Board
        [HttpPost]
        public void Post([FromBody] Coordinates coordinates)
        {
            game.Shoot(coordinates);
        }

        // PUT: api/Board/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            Console.WriteLine("jestem");
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Console.WriteLine("delete");
        }
    }
}
