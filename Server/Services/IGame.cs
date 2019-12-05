using System.Collections.Generic;
using Server.Models.Board;
using Server.Models.Ships;

namespace Server.Services
{
    public interface IGame
    {
         Player Player1 { get; set; }
         Player Player2 { get; set; }
        void PutShip(int shipId, ShipType shipType, List<Square> shipSquares);
        void Shoot(Coordinates coordinates);

    }
}