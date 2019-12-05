using System;
using System.Collections.Generic;
using Server.Models.Board;
using Server.Models.Ships;

namespace Server.Services
{
    public class ShipFactory
    {
        public Ship CreateShip(List<Square> shipSquares)
        {
            switch (shipSquares.Count)
            {
                case 2:
                    break; //destroyer

                case 3:
                    break; //cruiser

                case 4:
                    break; //battleship

                case 5:
                    return new Carrier(shipSquares);
                default:
                    return new Ship(shipSquares);
            }

            return null;
        }
    }
}