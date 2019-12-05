using System;
using System.Collections.Generic;
using Server.Models.Board;
using Server.Models.Ships;

namespace Server.Services
{
    public class ShipFactoryMethod
    {
        public Ship CreateShip(int shipId, ShipType shipType, List<Square> shipSquares)
        {
            switch (shipType)
            {
                case ShipType.Carrier:
                    return new Carrier(shipId, shipSquares);

                case ShipType.Battleship:
                    break;

                case ShipType.Cruiser:
                    break;

                case ShipType.Destroyer:
                    break;

                case ShipType.Submarine:
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(shipType), shipType, null);
            }

            return null;
        }
    }
}