using System;
using System.Collections.Generic;
using System.Linq;
using Server.Models.Ships;
using Server.Services;

namespace Server.Models.Board
{
    public class GameBoard
    {
        public List<Square> Board { get; private set; }
        public Fleet Fleet { get; set; }

        public GameBoard()
        {
            GenerateAllSquares();
            CreateFleet();
            bool x;
        }

        private void GenerateAllSquares()
        {
            this.Board = new List<Square>();
            for (var row = 1; row <= 10; row++)
            {
                for ( var column = 1; column <= 10; column++)
                {
                    Board.Add(new Square(row,column));
                }
            }
        }

        private void CreateFleet()
        {
            this.Fleet = new Fleet();
            bool AllShipsOnBoard = false;
            var unusedSquares = new List<Square>(this.Board);
            var shipLengths = new[] {2, 3, 3, 4, 5};
            foreach (var shipLength in shipLengths)
            {
                var rnd = new Random();
                var orientation = (Orientation) rnd.Next(Enum.GetNames(typeof(Orientation)).Length);
                Square startSquare = PickRandomSquare(shipLength,orientation);
                int row = startSquare.Coordinates.Row;
                int col = startSquare.Coordinates.Column;
                var shipBody = new List<Square>();
                if (orientation == Orientation.Horizontal)
                {
                    int[] horizontal = new int[shipLength];
                    for (int i = col; i < col + shipLength; i++) horizontal[i - col] = i;
                    int vertical = row;
                    foreach (var square in unusedSquares.ToList())
                    {
                        if (square.Coordinates.Row == vertical && horizontal.Contains(square.Coordinates.Column))
                        {
                            shipBody.Add(square);
                            unusedSquares.Remove(square);
                        }
                    }
                }
                else
                {
                    
                    int[] vertical = new int[shipLength];
                    for (int i = row; i < row + shipLength; i++) vertical[i - row] = i;
                    int horizontal = col;
                    foreach (var square in unusedSquares.ToList())
                    {
                        if (square.Coordinates.Column == horizontal && vertical.Contains(square.Coordinates.Row))
                        {
                            shipBody.Add(square);
                            unusedSquares.Remove(square);
                        }
                    }
                }
                Fleet.AddShip(ShipFactory.CreateShip(shipBody));
                foreach (var shipSquare in shipBody)
                {
                    foreach (var oceanSquare in unusedSquares.ToList())
                    {
                        if (oceanSquare.IsNeighbour(shipSquare)) unusedSquares.Remove(oceanSquare);
                    }
                }
            }
            

            Square PickRandomSquare(int shipLength, Orientation orientation)
            {
                while (true)
                {
                    var rnd = new Random();
                    var s = unusedSquares[rnd.Next(unusedSquares.Count)];
                    if (!CheckIfAllFieldsOfShipAreAvailable(s, shipLength, orientation)) continue;
                    switch (orientation)
                    {
                        case Orientation.Horizontal when s.Coordinates.Column <= 11 - shipLength:
                            return s;
                        case Orientation.Vertical when s.Coordinates.Row <= 11 - shipLength:
                            return s;
                        default:
                            continue;
                    }
                }
            }
            

            bool CheckIfAllFieldsOfShipAreAvailable(Square square, int length, Orientation orientation)
            {
                int countdownOfAvailable = length;
                int sqRow = square.Coordinates.Row;
                int sqCol = square.Coordinates.Column;
                if (orientation == Orientation.Horizontal)
                {

                    
                    
                        foreach (var unusedSquare in unusedSquares)
                        {
                            int unRow = unusedSquare.Coordinates.Row;
                            int unCol = unusedSquare.Coordinates.Column;
                            if (unRow == sqRow && unCol >= sqCol && unCol < sqCol + length)
                                countdownOfAvailable--;
                        }


                }
                else
                {

                        foreach (var unusedSquare in unusedSquares)
                        {
                            int unRow = unusedSquare.Coordinates.Row;
                            int unCol = unusedSquare.Coordinates.Column;
                            if (unCol == sqCol && unRow >= sqRow && unRow < sqRow + length)
                                countdownOfAvailable--;
                        }
                }

                return countdownOfAvailable == 0;
            }
        }

        

        enum Orientation
        {
            Horizontal,
            Vertical
        } 
    }
}