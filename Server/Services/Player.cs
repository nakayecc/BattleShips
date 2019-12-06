using Server.Models.Board;

namespace Server.Services
{
    public class Player
    {
        public Player(string name)
        {
            Name = name;
            Ocean = new GameBoard();
        }

        public GameBoard Ocean { get; }

        public bool HasLost()
        {
            return Ocean.Fleet.IsDestroyed();
        }
        public string Name { get; set; }


    }
}