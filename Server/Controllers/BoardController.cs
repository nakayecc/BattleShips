﻿using System;
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
            return "value";
        }

        // POST: api/Board
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Board/5
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
