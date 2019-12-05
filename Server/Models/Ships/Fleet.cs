using System.Collections.Generic;
using System.Linq;
using Server.Models.Board;

namespace Server.Models.Ships
{
    public class Fleet
    {
        public List<Ship> Ships { get; set;  }

        public bool IsDestroyed()
        {
            return Ships.Count == Ships.Count(ship => ship.IsDestroyed);
        }

        public Fleet()
        {
            this.Ships = new List<Ship>();
        }

        public bool CheckIfSquareIsShip(Square square)
        {
            return Ships.Any(ship => ship.CheckIfSquareIsInShip(square));
        }

        public void AddShip(Ship ship)
        {
            Ships.Add(ship);
        }
    }
}