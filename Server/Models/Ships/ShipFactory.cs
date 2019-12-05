using System;
using System.Collections.Generic;
using Server.Models.Board;
using Server.Models.Ships;

namespace Server.Services
{
    public class ShipFactory
    {
        public static Ship CreateShip(List<Square> shipSquares)
        {
            switch (shipSquares.Count)
            {
                case 2:
                    return new Destroyer(shipSquares);
                case 3:
                    return new Cruiser(shipSquares);
                case 4:
                    return new Battleship(shipSquares);
                case 5:
                    return new Carrier(shipSquares);
                default:
                    return new Ship(shipSquares);
            }

            return null;
        }
    }
}