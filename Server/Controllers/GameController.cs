using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Server.Services;

namespace Server.Controllers
{    
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowMyOrigin")]
    public class GameController : Controller
    {
        readonly IGame game;
        public GameController(IGame game)
        {
            this.game = game;
        } 
        
        [HttpGet]
        public IGame Get()
        {
            return game;
        }
    }
}