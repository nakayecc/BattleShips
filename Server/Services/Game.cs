using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Server.Models.Board;
using Server.Models.Ships;

namespace Server.Services
{
    public class Game
    {
        public GameBoard PlayerGameBoard { get; set;}
        public GameBoard EnemyGameBoard { get; set;}
        public Shipyard Shipyard { get; }


        public Game()
        {
            PlayerGameBoard = new GameBoard();
            EnemyGameBoard = new GameBoard();
            Shipyard = new Shipyard();
    }


        public void PutShip(int shipId, ShipType shipType, List<Square> shipSquares)
        {
            var ship = Shipyard.CreateShip(shipId,shipType,shipSquares);

            foreach (var boardSquare in ship.ShipSquares.SelectMany(shipSquare => PlayerGameBoard.Board
                .Where(boardSquare => shipSquare.Coordinates.Column == boardSquare.Coordinates.Column && shipSquare.Coordinates.Row == boardSquare.Coordinates.Row)))
            {
                boardSquare.fieldType = FieldType.Ship;
            }
        }

    }
}