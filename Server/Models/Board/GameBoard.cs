using System.Collections.Generic;

namespace Server.Models.Board
{
    public class GameBoard
    {
        public List<Square> Board { get; set; }

        public GameBoard()
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
    }
}