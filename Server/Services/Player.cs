using Server.Models.Board;

namespace Server.Services
{
    public class Player
    {
        public Player()
        {
            Ocean = new GameBoard();
            HasLost = false;
        }

        public GameBoard Ocean { get; set; }
        public bool HasLost { get; set; }
        
        
    }
}