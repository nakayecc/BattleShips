using System.Collections.Generic;
using Server.Models.Board;

namespace Server.Models.Ships
{
    public class Carrier : Ship
    {
        public Carrier(int id, List<Square> shipSquares)
        {
            this.ShipSquares = shipSquares;
            this.Id = id;
            this.Name = "Carrier";
            this.Type = ShipType.Carrier;
        }
    }
}