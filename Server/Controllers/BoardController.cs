using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Serialization;
using Server.Models.Board;


namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowMyOrigin")]
    public class BoardController : ControllerBase
    {
        public Services.Board GameBoard= new Services.Board();

            // GET: api/Board
        [HttpGet]
        public List<Square> Get()
        {
            GameBoard.InitBoard();
            
            return GameBoard.GameBoard.Board;
        }

        // GET: api/Board/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            Console.WriteLine("get");
            return "value";
        }

        // POST: api/Board
        [HttpPost]
        public void Post([FromBody] Coordinates dict)
        {
            Console.WriteLine("post");
        }

        // PUT: api/Board/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            Console.WriteLine("jestem");
            GameBoard.ChangeSquare(FieldType.Ship, id );
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Console.WriteLine("delete");
        }
    }
}
