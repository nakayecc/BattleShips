using System.Collections.Generic;
using Server.Models.Board;

namespace Server.Models.Ships
{
    public class Ship
    {
        public List<Square> ShipSquares { get; set; }
        public List<Square> Neighbours { get; }

        public Ship(List<Square> field)
        {
            ShipSquares = field;
            foreach (var square in field)
            {
                square.fieldType = FieldType.Ship;
            }
        }
        public bool IsDestroyed { get; set; }

        public bool CheckIfSquareIsInShip(Square square)
        {
            foreach (var part in ShipSquares)
            {
                if (square.Equals(part)) return true;
            }

            return false;
        }
    }
}