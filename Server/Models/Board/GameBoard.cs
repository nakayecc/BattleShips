using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace BattleShip.Models.Board
{
    public class GameBoard
    {
        public List<Cell> Board { get; set; }

        public GameBoard()
        {
            this.Board = new List<Cell>();

            for (var row = 1; row <= 10; row++)
            {
                for ( var column = 1; column <= 10; column++)
                {
                    Board.Add(new Cell(row,column));
                }
            }
        }
    }
}