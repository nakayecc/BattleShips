using System.Collections.Generic;
using Server.Models.Board;

namespace Server.Models.Ships
{
    public class Ship
    {
        public List<Square> ShipSquares { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public ShipType Type { get; set; }
    }
}