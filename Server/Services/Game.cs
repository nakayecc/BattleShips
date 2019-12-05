using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Server.Models.Board;
using Server.Models.Ships;

namespace Server.Services
{
    public class Game : IGame
    {
        public GameBoard PlayerGameBoard { get; set;}
        public GameBoard EnemyGameBoard { get; set;}
        public Shipyard Shipyard { get; set; }


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

        public void Shoot(Coordinates coordinates)
        {
            foreach (var square in PlayerGameBoard.Board)
            {
                if (square.Coordinates.Column == coordinates.Column && square.Coordinates.Row == coordinates.Row)
                {
                    if (square.IsOccupied())
                    {
                        Console.WriteLine("eloooo");
                        square.fieldType = FieldType.Miss;
                    }
                    else
                    {
                        square.fieldType = FieldType.Hit;
                    }
                }
            }
        }

    }
}