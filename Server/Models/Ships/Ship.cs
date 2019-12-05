using System.Collections.Generic;
using Server.Models.Board;

namespace Server.Models.Ships
{
    public class Ship
    {
        public List<Square> ShipSquares { get; set; }
        public List<Square> Neighbours { get; }
        public bool IsDestroyed { get; set; }
    }
}