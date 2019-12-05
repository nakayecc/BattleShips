using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server.Services;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WinCheckController : ControllerBase
    {
        private readonly IGame game;

        public WinCheckController(IGame game)
        {
            this.game = game;
        }

        // GET: api/WinCheck
        [HttpGet]
        public string Get()
        {
            return game.win;
        }
    }
}
