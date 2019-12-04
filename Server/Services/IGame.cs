using System.Collections.Generic;
using Server.Models.Board;
using Server.Models.Ships;

namespace Server.Services
{
    public interface IGame
    {
         GameBoard PlayerGameBoard { get; set; }
         GameBoard EnemyGameBoard { get; set; }
         Shipyard Shipyard { get; set; }
        void PutShip(int shipId, ShipType shipType, List<Square> shipSquares);
        void Shoot(Coordinates coordinates);

    }
}